﻿using MultimodeSales.Programacion;
using MultimodeSales.Programacion.Utilerias;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimodeSales.Vistas.Ventas
{
    public partial class Ticket : Form
    {
        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
        private int MX = 0;
        private int MY = 0;
        public Ticket()
        {
            InitializeComponent();
            printButton.Text = "Print Form";
            printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            barraSuperior.picMinimize.Click += new EventHandler(MinimizedClick);
            barraSuperior.picClose.Click += new EventHandler(CloseClick);
        }
        
        void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(Object sender,
               PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void MinimizedClick(object sender, EventArgs e)
        {
            WindowState = CBarraSuperior.Minimized();
        }
        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                MX = e.X;
                MY = e.Y;
            }
            else
            {
                Left = Left + (e.X - MX);
                Top = Top + (e.Y - MY);
            }
        }

        private void barraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(sender, e);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
