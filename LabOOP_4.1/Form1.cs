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
            public bool IsDrawed = true; //отрисован ли круг на полотне

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

        private void RemoveSelect(ref Storage storage) //снимаем выделение у элементов хранилища
        {   
            for (int i = 0; i < kol; ++i)
            {
                if (!stg.CheckEmpty(i))
                {   
                    Paint(Color.RoyalBlue, ref stg, i); //рисуем круг
                }
            }
        }

        private void RemoveSelectStg(ref Storage storage) //удаление выделенных элементов из хранилища
        {   
            for (int i = 0; i < kol; ++i)
            {
                if (!stg.CheckEmpty(i))
                {
                    if (stg.objects[i].color == Color.Red)
                    {
                        stg.DeleteObject(i);
                    }
                }
            }
        }
        private void Paint(Color color,ref Storage storage, int index)
        {
            Pen pen = new Pen(color, 5); //инициализация "карандаша" для рисования (цвет и ширина контура)
            if (!stg.CheckEmpty(index))
            {
                if (stg.objects[index].IsDrawed == true)
                {
                    panelPaint.CreateGraphics().DrawEllipse(
                    pen, storage.objects[index].x, storage.objects[index].y, storage.objects[index].radius, storage.objects[index].radius);
                    storage.objects[index].color = color;
                }
            }
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

            public void DeleteObject(int ind)
            {   // Удаляет объект из хранилища
                objects[ind] = null;
                index--;
            }
            public int Occupied(int size) //количество занятых мест в хранилище
            {
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!CheckEmpty(i))
                        ++count_occupied;
                return count_occupied;
            }
            public bool CheckEmpty(int index) //проверка на занятую ячейку в хранилище
            {   
                if (objects[index] == null)
                    return true;
                else return false;
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

        int ctrl = 0; 
        static int kol = 5; //изначальный объём хранилища
        static int index = 0;
        Storage stg = new Storage(kol);
        int index2 = 0;
        private void panelPaint_MouseClick(object sender, MouseEventArgs e) //клик по панели рисования
        {
            CCircle circle = new CCircle(e.X, e.Y);
            if (index == kol) //если индекс элемента равен значению объема хранилища - увеличить хран. в два раза
            {
                stg.doubleSize(ref kol);
            }
            int c = CheckCircle (ref stg, kol, circle.x, circle.y);
            if (c != -1) //если на координатах уже расположег круг
            {   
                if (Control.ModifierKeys == Keys.Control) //если нажат Control, выделяем несколько кругов
                {   
                    if (ctrl == 0)
                    {
                        Paint(Color.RoyalBlue, ref stg, index2);
                        ctrl = 1;
                    }
                    Paint(Color.Red, ref stg, c); //рисуем круг
                }
                else // иначе выделяем только один объект
                {   
                    RemoveSelect(ref stg);
                    Paint(Color.Red, ref stg, c); //рисуем круг
                }
                return;
            }
            stg.AddObjectStg(index, ref circle, kol, ref index2); //добавить объект в хранилище

            Paint(Color.RoyalBlue, ref stg, index); //нарисовать круг на полотне
            index++;
        }

        private int CheckCircle(ref Storage stg, int size, int x, int y) //проверка круга с такими же координатами в хранилище
        {   
            if (stg.Occupied(size) != 0) 
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.CheckEmpty(i))
                    {
                        int x1 = stg.objects[i].x - 15;
                        int x2 = stg.objects[i].x + 15;
                        int y1 = stg.objects[i].y - 15;
                        int y2 = stg.objects[i].y + 15;

                        if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2)) // если круг есть, возвращет индекс круга
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        private void buttonClear_Click(object sender, EventArgs e) //очистить полотно
        {
            panelPaint.Refresh();
            for (int i = 0; i < kol; ++i)
            {
                if (!stg.CheckEmpty(i))
                {  
                    stg.objects[i].IsDrawed = false;
                }
            }
        }

        private void buttonClearStg_Click(object sender, EventArgs e) //удалить объекты из хранилища
        {
            for (int i = 0; i < kol; ++i)
            {
                stg.objects[i] = null;
            }
            index = 0;
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            panelPaint.Refresh();
            if (stg.Occupied(kol) != 0)
            {
                for (int i = 0; i < kol; ++i)
                {
                    if (!stg.CheckEmpty(i))
                    {    
                        stg.objects[i].IsDrawed = true;
                    }
                    Paint(Color.RoyalBlue, ref stg, i);
                }
            }
        }

        private void buttonDeleteActiveStg_Click_1(object sender, EventArgs e)
        {
            RemoveSelectStg(ref stg);
            panelPaint.Refresh();
            if (stg.Occupied(kol) != 0)
            {
                for (int i = 0; i < kol; ++i)
                {
                    Paint(Color.RoyalBlue, ref stg, i);
                }
            }
        }
    }

}
