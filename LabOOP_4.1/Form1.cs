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
            public int x, y; //координаты круга
            public int radius = 50; //радиус круга
            public Color color = Color.RoyalBlue; //основной цвет круга

            public CCircle() //конструктор по умолчанию
            {
                x = 0;
                y = 0;
            }

            public CCircle(int x, int y) //конструктор с параметрами
            {
                this.x = x-radius/2;
                this.y = y-radius/2; //минус радиус делить на два для создания круга по центру курсора
            }

            ~CCircle() //деструктор
            {

            }
        }

        private void Paint(Color color,ref Storage storage, int index)
        {
            Pen pen = new Pen(color, 5); //инициалзация "карандаша" для рисования
            panelPaint.CreateGraphics().DrawEllipse(pen, storage.objects[index].x, storage.objects[index].y, storage.objects[index].radius, storage.objects[index].radius);
        }



        class Storage  //класс-хранилище
        {
            public CCircle[] objects;

            public Storage() //конструктор по умолчанию
            {

            }
            public void initial(int count) //метод (конструктора с параметрами)
            { 
                objects = new CCircle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public Storage(int count) //конструктор с параметром
            {
                objects = new CCircle[count];
                for (int i = 0; i < count; ++i)
                {
                    objects[i] = null;
                }
            }
            ~Storage() //деструктор
            {

            }

            public void AddObjectStg(int index, ref CCircle obj, int count, ref int indexin) //добавить объект в хранилище
            {
                while (objects[index] != null)
                {
                    index = (index + 1) % count;
                }
                objects[index] = obj;
                indexin = index;
            }
            public void doubleSize(ref int size) //метод для увеличения объёма хранилища в два раза
            {
                Storage storage1 = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                    storage1.objects[i] = objects[i];
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size * 2;
                initial(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = storage1.objects[i];
            }
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e) //координаты мыши на полотне
        {
            labelCoordX.Text = e.X.ToString();
            labelCoordY.Text = e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //координаты мыши на форме
        {
            labelCoordX.Text = "0";
            labelCoordY.Text = "0";
        }

        static int kol = 5;
        int index = 0;
        Storage stg = new Storage(kol);
        int index2 = 0;
        private void panelPaint_MouseClick(object sender, MouseEventArgs e) //клик по панели рисования
        {
            CCircle circle = new CCircle(e.X, e.Y);
            if (index == kol) //если индекс элемента равен значению объема хранилища - увеличить хран. в два раза
            {
                stg.doubleSize(ref kol);
            }

            stg.AddObjectStg(index, ref circle, kol, ref index2); //добавить объект в хранилище

            Paint(Color.RoyalBlue, ref stg, index); //нарисовать круг на полотне
            index++;
        }

    }

}
