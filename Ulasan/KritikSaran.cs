using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
namespace Ulasan
{
    public partial class KritikSaran : Form
    {
        private Size formOriginalSize;
        private Rectangle recpanel1;
        private Rectangle rectableLayoutPanel1;
        private Rectangle recpanel3;
        private Rectangle rectextBox2;
        private Rectangle reclabel4;
        private Rectangle reclabel5;
        private Rectangle reclabel6;
        private Rectangle reclabel7;
        private Rectangle recpanel2;
        private Rectangle rectextBox1;
        private Rectangle reclabel3;
        private Rectangle reclabel2;
        private Rectangle reclabel1;
        private Rectangle recrating1;
        private Rectangle recpanel7;
        private Rectangle rectextBox6;
        private Rectangle reclabel20;
        private Rectangle reclabel21;
        private Rectangle reclabel22;
        private Rectangle reclabel23;
        private Rectangle recpanel6;
        private Rectangle rectextBox5;
        private Rectangle reclabel16;
        private Rectangle reclabel17;
        private Rectangle reclabel18;
        private Rectangle reclabel19;
        private Rectangle recpanel5;
        private Rectangle rectextBox4;
        private Rectangle reclabel12;
        private Rectangle reclabel13;
        private Rectangle reclabel14;
        private Rectangle reclabel15;
        private Rectangle recpanel4;
        private Rectangle rectextBox3;
        private Rectangle reclabel8;
        private Rectangle reclabel9;
        private Rectangle reclabel10;
        private Rectangle reclabel11;
        private Rectangle reccontextMenuStrip1;
        private Rectangle reclabel24;
        private Rectangle recpanel14;
        private Rectangle recpictureBox2;
        private Rectangle recpictureBox3;
        private Rectangle recpictureBox1;
        public KritikSaran()
        {
            InitializeComponent();
            this.Resize += KritikSaran_Resize;
            formOriginalSize = this.Size;
            recpanel1 = new Rectangle(panel1.Location, panel1.Size);
            recpanel2 = new Rectangle(panel2.Location, panel2.Size);
            recpanel3 = new Rectangle(panel3.Location, panel3.Size);
            recpanel4 = new Rectangle(panel4.Location, panel4.Size);
            recpanel5 = new Rectangle(panel5.Location, panel5.Size);
            recpanel6 = new Rectangle(panel6.Location, panel6.Size);
            recpanel7 = new Rectangle(panel7.Location, panel7.Size);
            recpictureBox1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpictureBox2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
            recpictureBox3 = new Rectangle(pictureBox3.Location, pictureBox3.Size);
            recrating1 = new Rectangle(rating1.Location, rating1.Size);
            reccontextMenuStrip1 = new Rectangle(contextMenuStrip1.Location , contextMenuStrip1.Size);
            reclabel1 = new Rectangle(label1.Location,label1.Size);
            reclabel2 = new Rectangle(label2.Location,label2.Size);
            reclabel3 = new Rectangle(label3.Location,label3.Size);
            reclabel4 = new Rectangle (label4.Location,label4.Size);
            reclabel5 = new Rectangle(label5.Location,label5.Size);
            reclabel6 = new Rectangle(label6.Location,label6.Size);
            reclabel7 = new Rectangle (label7.Location,label7.Size);
            reclabel8 = new Rectangle (label8.Location,label8.Size);
            reclabel9 = new Rectangle (label9.Location,label9.Size);
            reclabel10 = new Rectangle(label10.Location,label10.Size);
            reclabel11 = new Rectangle(label11.Location,label11.Size);
            reclabel12 = new Rectangle(label12.Location,label12.Size);
            reclabel13 = new Rectangle(label13.Location,label13.Size);
            reclabel14 = new Rectangle (label14.Location,label14.Size);
            reclabel15 = new Rectangle (label15.Location,label15.Size);
            reclabel16 = new Rectangle  (label16.Location,label16.Size);
            reclabel17 = new Rectangle (label17.Location,label17.Size);
            reclabel18 = new Rectangle (label18.Location,label18.Size);
            reclabel19 = new Rectangle (label19.Location,label19.Size);
            reclabel20 = new Rectangle (label20.Location,label20.Size);
            reclabel21 = new Rectangle (label21.Location,label21.Size);
            reclabel22 = new Rectangle (label22.Location,label22.Size);
            reclabel23 = new Rectangle (label23.Location,label23.Size);
            reclabel24 = new Rectangle (label24.Location,label24.Size);
            
        }
        private void KritikSaran_Resize(object sender, EventArgs e)
        {
            resize_Control(panel1, recpanel1);
            resize_Control(panel2, recpanel2);
            resize_Control(panel3, recpanel3);
            resize_Control(panel4, recpanel4);
            resize_Control(panel5, recpanel5);
            resize_Control(panel6, recpanel6);
            resize_Control(panel7, recpanel7);
            resize_Control(label1, reclabel1);
            resize_Control(label2, reclabel2);
            resize_Control(label3, reclabel3);
            resize_Control(label4, reclabel4);
            resize_Control(label5, reclabel5);
            resize_Control(label6, reclabel6);
            resize_Control(label7, reclabel7);
            resize_Control(label8, reclabel8);
            resize_Control(label9, reclabel9);
            resize_Control(label10, reclabel10);
            resize_Control(label11, reclabel11);
            resize_Control(label12, reclabel12);
            resize_Control(label13, reclabel13);
            resize_Control(label14, reclabel14);
            resize_Control(label15, reclabel15);
            resize_Control(label16, reclabel16);
            resize_Control(label17, reclabel17);
            resize_Control(label18, reclabel18);
            resize_Control(label19, reclabel19);
            resize_Control(label20, reclabel20);
            resize_Control(label21, reclabel21);
            resize_Control(label22, reclabel22);
            resize_Control(label23, reclabel23);
            resize_Control(label24, reclabel24);
            resize_Control(rating1,recrating1);
            resize_Control(contextMenuStrip1,reccontextMenuStrip1);
            resize_Control(pictureBox1, recpictureBox1);
            resize_Control(pictureBox2, recpictureBox2);
            resize_Control(pictureBox3, recpictureBox3);

        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
    }
}



