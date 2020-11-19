using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOOP_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class CCircle
        {
            public int x, y;
            public int radius = 25;

            public CCircle() //конструктор по умолчанию
            {
                x = 0;
                y = 0;
            }

            public CCircle(int x, int y) //конструктор с параметрами
            {
                this.x = x;
                this.y = y;
            }

            ~CCircle() //деструктор
            {

            }
        }

        class Storage
        {
            public CCircle[] objects;

            public Storage(int count)
            {
                objects = new CCircle[count];
                for (int i =0; i<count; ++i)
                {
                    objects[i] = null;
                }
            }
            ~Storage()
            {

            }
        }

    }
}
