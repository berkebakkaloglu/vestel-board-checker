using System;
using System.Collections.Generic;

namespace SimpleDrawer
{
    public class Tester
    {
        bool holeMinSpaceFailed;
        float distanceBetweenHoles;
        InvalidHole invalidHole;
        List<string> errorType;

        List<InvalidHole> invalidHoleList = new List<InvalidHole>();

        int boardWidth, boardHeight;
        List<HoleInfo> holeInfoList;
        float minimumSpace;

        public Tester(int boardWidth, int boardHeight, List<HoleInfo> holeInfoList, float minimumSpace)
        {
            this.boardWidth = boardWidth;
            this.boardHeight = boardHeight;
            this.holeInfoList = holeInfoList;
            this.minimumSpace = minimumSpace;
        }

        public void testHoles()
        {
            checkHoleConditions();

            printOutput();
        }

        public void checkHoleConditions()
        {
            for (int i = 0; i < holeInfoList.Count - 1; i++)
            {
                errorType = new List<string>();

                for (int j = i + 1; j < holeInfoList.Count; j++)
                {
                    holeMinSpaceFailed = false;

                    addErrorTypes(i, j);
                }
            }
        }

        private void addErrorTypes(int i, int j)
        {
            if (failsHoleConditions(holeInfoList[i], holeInfoList[j]))
            {
                if (holeMinSpaceFailed)
                {
                    errorType.Add("X: " + holeInfoList[j].holeXCoordinate + " Y: " + holeInfoList[j].holeYCoordinate + " R: " + holeInfoList[j].holeDiameter +
                                  " / KAÇMA: X" + holeInfoList[j].holeXEscape + " Y" + holeInfoList[j].holeYEscape +
                                  " (FAZLA YAKIN / " + distanceBetweenHoles.ToString("0.000") + " mm)");
                }
                else
                {
                    errorType.Add("X: " + holeInfoList[j].holeXCoordinate + " Y: " + holeInfoList[j].holeYCoordinate + " R: " + holeInfoList[j].holeDiameter +
                                  " (ÇAKIŞMA)");
                }

                invalidHole = new InvalidHole(holeInfoList[i], errorType);
                invalidHoleList.Add(invalidHole);
            }
        }

        public bool failsHoleConditions(HoleInfo holeOne, HoleInfo holeTwo)
        {
            setHoleVariables(holeOne, holeTwo);

            if (distanceBetweenHoles <= 0)
            {
                return true;
            }
            else if (distanceBetweenHoles <= minimumSpace)
            {
                holeMinSpaceFailed = true;
                return true;
            }
            return false;
        }

        private void setHoleVariables(HoleInfo holeOne, HoleInfo holeTwo)
        {
            float holeOneRadius = holeOne.holeDiameter / 2;
            float centeredHoleOneXCoordinate = holeOne.holeXCoordinate + holeOne.holeXEscape;
            float centeredHoleOneYCoordinate = holeOne.holeYCoordinate - holeOne.holeYEscape;

            float holeTwoRadius = holeTwo.holeDiameter / 2;
            float centeredHoleTwoXCoordinate = holeTwo.holeXCoordinate + holeTwo.holeXEscape;
            float centeredHoleTwoYCoordinate = holeTwo.holeYCoordinate - holeTwo.holeYEscape;

            float holeXDifference = centeredHoleOneXCoordinate - centeredHoleTwoXCoordinate;
            float holeYDifference = centeredHoleOneYCoordinate - centeredHoleTwoYCoordinate;

            float holeXDifferenceSquared = holeXDifference * holeXDifference;
            float holeYDifferenceSquared = holeYDifference * holeYDifference;
            float distanceBetweenCenters = (float)Math.Sqrt(holeXDifferenceSquared + holeYDifferenceSquared);

            distanceBetweenHoles = distanceBetweenCenters - (holeOneRadius + holeTwoRadius);
        }

        public void printOutput()
        {
            string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fileDirectory = System.IO.Path.Combine(desktopDirectory, "errors.txt");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileDirectory, false))
            {
                if (invalidHoleList.Count == 0)
                {
                    file.WriteLine("Hata bulunmadı.");
                }
                else
                {
                    printErrors(file);
                }
            }
        }

        private void printErrors(System.IO.StreamWriter file)
        {
            file.WriteLine("Geçersiz Delikler: ");

            foreach (InvalidHole invalidHole in invalidHoleList)
            {
                file.WriteLine("");
                file.WriteLine("X: " + invalidHole.holeInfo.holeXCoordinate + " Y: " + invalidHole.holeInfo.holeYCoordinate + " R: " + invalidHole.holeInfo.holeDiameter +
                               " / KAÇMA: X" + invalidHole.holeInfo.holeXEscape + " Y" + invalidHole.holeInfo.holeYEscape);

                for (int i = 0; i < invalidHole.errorType.Count; i++)
                {
                    file.WriteLine(invalidHole.errorType[i]);
                }
            }
        }
    }
}
