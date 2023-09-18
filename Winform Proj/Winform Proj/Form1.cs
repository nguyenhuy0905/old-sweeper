using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace Winform_Proj
{   
    public partial class Form1 : Form
    {       
        int rowz = 18, colz = 18;
        bool confirm = false;
        bool newGame = false;
        MineCell[,] cell = new MineCell[60, 60];
        int numMines = 40;     //số mìn chưa add vào 
        DateTime startTime;
        public Form1()
        {            
            InitializeComponent();
        }
        private void InitialData(MineCell[,] cell)
        {
            if (rowz > 60 || colz > 60) confirm = false;
            if (confirm == true)
            {
                for (int i = 0; i < rowz; i++)
                {
                    for (int j = 0; j < colz; j++)
                    {
                        cell[i, j] = new MineCell();
                        cell[i, j].cell = new Button();                       
                        var ctr = cell[i, j].cell;
                        ctr.Anchor = (AnchorStyles.None);                       
                        ctr.Name = $"{cell[i, j].Status + 1}";
                        ctr.Tag = i + " " + j;
                        ctr.MouseDown += (sender, e) =>
                        {
                            if (e.Button == MouseButtons.Left && ctr.Image == null && ctr.Text == "")
                            {
                                Open(sender);
                                if (ctr.Name.ToString() == "9")
                                {
                                    ctr.Text = "*";
                                    for (int a = 0; a < rowz; a++)
                                    {
                                        for(int b = 0; b < colz; b++)
                                        {
                                            if (cell[a, b].cell.Name == "9")
                                            {
                                                cell[a, b].cell.Text = "*";
                                                cell[a, b].cell.BackColor = SystemColors.Control;
                                            }
                                        }
                                    }
                                    MessageBox.Show("You lose" + "\n" + "Time Played: " + TimeBox.Text);
                                    Start();
                                }
                            }
                            if (e.Button == MouseButtons.Right)
                            {
                                if ((sender as Button).Image == null && (sender as Button).BackColor == SystemColors.ActiveCaption)
                                {
                                    (sender as Button).Image = imageList1.Images["flag.ico"];
                                    (sender as Button).BackColor = SystemColors.Control;
                                    if ((sender as Button).Name == "9")
                                    {
                                        numMines -= 1;
                                        if (numMines == 0)
                                        {
                                            MessageBox.Show("YOU WON!" + "\n" + "Time Played: " + TimeBox.Text);
                                            Start();
                                        }                                       
                                    }                                   
                                }
                                else if ((sender as Button).Image != null) 
                                {
                                    (sender as Button).Image = null;
                                    (sender as Button).BackColor = SystemColors.ActiveCaption;
                                    if ((sender as Button).Name == "9")
                                    {
                                        numMines += 1;
                                    }
                                }
                            }
                        };
                        ctr.BackColorChanged += (sender, e) => 
                        {
                            if (MouseButtons == MouseButtons.Left)
                            {
                                string[] coords = (sender as Button).Tag.ToString().Split(' ');
                                if ((sender as Button).Name == "0")
                                {
                                    for (int x = int.Parse(coords[0]) - 1; x < int.Parse(coords[0]) + 2; x++)
                                    {
                                        for (int y = int.Parse(coords[1]) - 1; y < int.Parse(coords[1]) + 2; y++)
                                        {
                                            if (x > -1 && x < rowz && y > -1 && y < rowz)
                                            {
                                                ctr = cell[x, y].cell;
                                                if (ctr.BackColor != SystemColors.Control)
                                                {
                                                    Open(ctr);
                                                }
                                            }
                                        }
                                    }
                                }
                            }                           
                        };
                    }
                }
                MineGenerate(cell);
                startTime = DateTime.Now;
            }
        }
        private void Open(object sender)
        {
            var ctr = (sender as Button);
            ctr.Text = $"{ctr.Name}";
            ctr.BackColor = SystemColors.Control;
            if (ctr.Name == "0")
            {
                ctr.Text = "";
            }
            if (ctr.Text == "1")
            {
                ctr.ForeColor = Color.Blue;
            }
            if (ctr.Text == "2")
            {
                ctr.ForeColor = Color.Green;
            }
            if (ctr.Text == "3")
            {
                ctr.ForeColor = Color.Tomato;
            }
            if (ctr.Text == "4")
            {
                ctr.ForeColor = Color.Red;
            }
            if (ctr.Text == "5")
            {
                ctr.ForeColor = Color.DarkBlue;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
        }
        private void DrawCell(MineCell[,] cell)
        {
            if (confirm == true && newGame==false)
            {
                for (int i = 0; i < rowz; i++)
                {
                    for (int j = 0; j < colz; j++)
                    {
                        cell[i, j].cols = j;
                        cell[i, j].rows = i;
                        var ctr = cell[i, j].cell;
                        Controls.Add(ctr);
                        ctr.Size = new Size(600 / rowz, 600 / colz);
                        ctr.Location = new Point(600 / rowz * i, 600 / colz * j + 30);
                        ctr.FlatStyle = FlatStyle.Flat;
                        ctr.BackColor = SystemColors.ActiveCaption;
                        cell[i, j].cell.TabStop = false;
                        cell[i, j].cell.Name = $"{cell[i, j].Status + 1}";
                        SetStyle(ControlStyles.Selectable, false);
                        cell[i, j].cell.Visible = true;
                    }
                }
            }
        }
        private void MineGenerate(MineCell[,] cell)
        { if (confirm == true) {
                Random r = new Random();
                int row, column;
                int MineLeft = numMines;
                while (MineLeft > 0)
                {
                    row = r.Next(0, rowz);
                    column = r.Next(0, colz);
                    if (column > 2 || row > 2)
                    {
                        if (cell[row, column].CanBeAdded != 0)
                        {
                            cell[row, column].CanBeAdded = 0;
                            cell[row, column].Status = 8;
                            MineLeft--;
                            string xy = cell[row,column].cell.Tag.ToString();
                            string[] coords = xy.Split(' ');
                            for (int x = int.Parse(coords[0]) - 1; x < int.Parse(coords[0]) + 2; x++)
                            {
                                for (int y = int.Parse(coords[1]) - 1; y < int.Parse(coords[1]) + 2; y++) 
                                {
                                    if (x > -1 && x < rowz && y > -1 && y < colz && cell[x,y].CanBeAdded != 0)
                                    {
                                        cell[x, y].Status += 1;
                                    }
                                }

                            }
                        }
                    }
                }
            }                                               
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (confirm == true) 
            {                
                TimeBox.Text = $"{Math.Round((DateTime.Now - startTime).TotalSeconds)}"; 
            }
                               
        }
        private void Start()
        {
            Form1 NewForm = new Form1();
            this.Dispose(false);
            NewForm.Show();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (rowBox.Text != "" && colBox.Text != "" && mineBox.Text != "")
            {
                //lấy độ dài hàng và cột, hide các item không cần thiết.
                rowz = int.Parse(rowBox.Text);
                colz = int.Parse(colBox.Text);
                numMines = int.Parse(mineBox.Text);
                rowBox.Visible = false;
                colBox.Visible = false;
                mineBox.Visible = false;
                numRowLabel.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                Confirm.Visible = false;
                PlaySavedGamesBox.Visible = false;
                //báo hiệu rằng người chơi đã tạo game mới
                confirm = true;
                //bắt đầu tạo bảng
                InitialData(cell);
                DrawCell(cell);
            }
        }
        private void TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).Text.Concat((sender as TextBox).Text.Where(char.IsNumber));
        }
        private void PlaySavedGamesBox_Click(object sender, EventArgs e)
        {

        }
        private void Save(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Nguyen Duc Hoan\source\repos\Winform Proj\Winform Proj\Saves\" + $"{(sender as ToolStripMenuItem).Text}" + ".txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine($"{rowz + " " + colz}");                   
                    bool clicked = false, flagged = false;
                    for (int i = 0; i < rowz; i++)
                    {
                        clicked = false; flagged = false;
                        for (int j = 0; j < colz; j++)
                        {
                            if (cell[i, j].cell.Text != "")
                            {
                                clicked = true;
                            }
                            else if (cell[i, j].cell.Image != null)
                            {
                                flagged = true;
                            }
                            sw.WriteLine($"{cell[i, j].cell.Tag + " " + cell[i, j].Status + " " + clicked + " " + flagged}");
                        }
                    }
                }
            }
        }
    }
}      