using Ader.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SimpleDrawer
{
    public partial class OutputForm : Form
    {
        int boardWidth;
        int boardHeight;
        float holeXCoordinate;
        float holeYCoordinate;
        float holeRadius;
        int colorCounter = 0;
        float scaleMultiplier = 1.0f;
        float sliderMultiplier = 1000000.0f;
        List<HoleInfo> holeInfoList = new List<HoleInfo>();
        StringTokenizer tokenizer;

        public OutputForm(int boardWidth, int boardHeight)
        {
            this.boardWidth = boardWidth;
            this.boardHeight = boardHeight;

            InitializeComponent();
        }

        private void addHoleButton_Click(object sender, EventArgs e)
        {
            if (!radiusBox.Text.Equals("") && !xEscapeBox.Text.Equals("") && !yEscapeBox.Text.Equals("") && !massInputBox.Text.Equals(""))
            {
                takeInput();

                panel2.Invalidate();

                massInputBox.Clear();
                radiusBox.Clear();
            }
        }

        public void takeInput()
        {
            tokenizer = new StringTokenizer(massInputBox.Text);
            tokenizer.IgnoreWhiteSpace = true;
            tokenizer.SymbolChars = new char[] { '-' };
            Token token;

            holeRadius = float.Parse(radiusBox.Text, CultureInfo.InvariantCulture);

            Color[] holeColors = new Color[8]
           { Color.Cyan, Color.Crimson, Color.DarkOrange, Color.Blue, Color.Fuchsia, Color.BlueViolet, Color.Lime, Color.Black };

            int counter = 0;
            do
            {
                token = tokenizer.Next();

                parseCoordinates(ref token, ref counter);

                if (counter % 3 == 2)
                {
                    float holeXEscape = float.Parse(xEscapeBox.Text, CultureInfo.InvariantCulture);
                    float holeYEscape = float.Parse(yEscapeBox.Text, CultureInfo.InvariantCulture);
                    HoleInfo holeInfo = new HoleInfo(holeXCoordinate, holeYCoordinate, holeRadius, holeXEscape, holeYEscape, holeColors[colorCounter % 8]);
                    holeInfoList.Add(holeInfo);
                    counter++;
                }
            }
            while (token.Kind != TokenKind.EOF);

            colorCounter++;
        }

        private void parseCoordinates(ref Token token, ref int counter)
        {
            if (token.Kind == TokenKind.Symbol)
            {
                token = tokenizer.Next();
                if (token.Kind == TokenKind.Number)
                {
                    if (counter % 3 == 0)
                    {
                        holeXCoordinate = float.Parse(token.Value, CultureInfo.InvariantCulture) * (-1);
                        counter++;
                    }
                    else if (counter % 3 == 1)
                    {
                        holeYCoordinate = float.Parse(token.Value, CultureInfo.InvariantCulture) * (-1);
                        counter++;
                    }
                }
            }
            else if (token.Kind == TokenKind.Number)
            {
                if (counter % 3 == 0)
                {
                    holeXCoordinate = float.Parse(token.Value, CultureInfo.InvariantCulture);
                    counter++;
                }
                else if (counter % 3 == 1)
                {
                    holeYCoordinate = float.Parse(token.Value, CultureInfo.InvariantCulture);
                    counter++;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = panel2.CreateGraphics();

            drawBoard(graphicsObj);

            drawHoles(graphicsObj);

            graphicsObj.Dispose();
        }

        private void drawBoard(Graphics graphicsObj)
        {
            Pen boardPen = new Pen(Color.Black, 1);
            RectangleF board = new RectangleF(0, 0,
                boardWidth * scaleMultiplier, boardHeight * scaleMultiplier);
            graphicsObj.DrawRectangle(boardPen, board.X, board.Y, board.Width, board.Height);

            SolidBrush boardBrush = new SolidBrush(Color.MediumSeaGreen);
            graphicsObj.FillRectangle(boardBrush, board);

            boardPen.Dispose();
            boardBrush.Dispose();
        }

        private void drawHoles(Graphics graphicsObj)
        {
            if (holeInfoList.Count != 0)
            {
                foreach (HoleInfo holeInfo in this.holeInfoList)
                {
                    float holeDiameter = holeInfo.holeDiameter;
                    float holeRadius = holeDiameter / 2;
                    float centeredHoleXCoordinate = (boardWidth / 2) + holeInfo.holeXEscape + holeInfo.holeXCoordinate - holeRadius;
                    float centeredHoleYCoordinate = (boardHeight / 2) - holeInfo.holeYEscape - holeInfo.holeYCoordinate - holeRadius;

                    Pen holePen = new Pen(holeInfo.holeColor, 1);
                    RectangleF hole = new RectangleF(
                        centeredHoleXCoordinate * scaleMultiplier, centeredHoleYCoordinate * scaleMultiplier,
                        holeDiameter * scaleMultiplier, holeDiameter * scaleMultiplier);
                    graphicsObj.DrawEllipse(holePen, hole);

                    SolidBrush holeBrush = new SolidBrush(holeInfo.holeColor);
                    graphicsObj.FillEllipse(holeBrush, hole);

                    holeBrush.Dispose();
                    holePen.Dispose();
                }
            }
        }

        private void OutputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (!minimumSpaceBox.Text.Equals(""))
            {
                float minimumSpace = float.Parse(minimumSpaceBox.Text, CultureInfo.InvariantCulture);

                progressLabel.ForeColor = Color.Black;
                progressLabel.Text = "Test Sürüyor";
                controlsPanel.Refresh();

                Tester tester = new Tester(boardWidth, boardHeight, holeInfoList, minimumSpace);
                tester.testHoles();

                progressLabel.Text = "Test Bitti";
                controlsPanel.Refresh();
            }
        }

        private void zoomTrackBar_Scroll(object sender, EventArgs e)
        {
            scaleMultiplier = zoomTrackBar.Value / sliderMultiplier;

            panel2.Invalidate();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            holeInfoList.Clear();
            colorCounter = 0;

            panel2.Invalidate();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            float xMultiplier = (float)panel2.Width / boardWidth;
            float yMultiplier = (float)panel2.Height / boardHeight;

            float minMultiplier = Math.Min(xMultiplier, yMultiplier);

            float maxSliderValue = minMultiplier * sliderMultiplier;

            zoomTrackBar.Maximum = (int)maxSliderValue;
            zoomTrackBar.Value = zoomTrackBar.Maximum;

            scaleMultiplier = zoomTrackBar.Maximum / sliderMultiplier;
        }

        private void newBoardButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
