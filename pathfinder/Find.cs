﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace pathfinder
{
    class Find
    {
        private static Label[,] labels = new Label[20,20];

        static public Label zacatek_label;
        static public Label konec_label;
        static public Stopwatch watch = new Stopwatch();
        public static List<Label> prekazky = new List<Label>();

        public static bool zacatek { get; private set; }
        public static bool konec { get; private set; }

        static public int[,] getlocation() {
            int[,] coor = new int[2, 2];
            
            for (int columb = 0; columb < 20; columb++)
            {
                for (int row = 0; row < 20; row++)
                {
                    if (labels[columb,row] == zacatek_label)
                    {
                        coor[0, 0] = columb;
                        coor[0, 1] = row;
                    }
                    if (labels[columb, row] == konec_label)
                    {
                        coor[1, 0] = columb;
                        coor[1, 1] = row;
                    }
                }
            }
            return coor;
        }

        public static void prepare(Control.ControlCollection control, Action<object, MouseEventArgs> callback) {
            Point loc = new Point(0, -40);
            for (int columb = 0; columb < 20; columb++)
            {
                loc.X = -40;
                loc.Y += 40;
                for (int row = 0; row < 20; row++)
                {
                    Label label = new Label();
                    label.AutoSize = false;
                    label.MouseDown += new MouseEventHandler(callback);
                    label.Size = new Size(40, 40);
                    label.BackColor = Color.LightGray;
                    loc.X += 40;
                    label.Location = loc;
                    labels[columb, row] = label;
                    //MessageBox.Show($"columb: {columb}\nrow: {row}");
                    control.Add(label);
                }
                
            }


        }

        internal static void go(Label info_cas, Label info_moves)
        {
            int[,] souradnice = Find.getlocation();         
            int pocetkroku = 0;
            int zacatek_y = souradnice[0, 0];
            int zacatek_x = souradnice[0, 1];
            int konec_y = souradnice[1, 0];
            int konec_x = souradnice[1, 1];
            watch.Start();
            
            double vzdalenost = Math.Sqrt((zacatek_y - konec_y) * (zacatek_y - konec_y) + (zacatek_x - konec_x)*(zacatek_x - konec_x));
           
            //najit cestu
            while (true)
            {
                int temp_pocet = pocetkroku;
                double start_time = DateTime.Now.Millisecond;
                MessageBox.Show(pocetkroku.ToString());
                double temp1 = 0, temp2 = 0, temp3 = 0, temp4 = 0;



                bool JdeTo = false;
                for (int i = 0; i <= 4; i++) //nejlepsi mozny pohyb
                {
                   
                    if (i == 0)
                    {
                        zacatek_x++;
                        if (zacatek_x > 20)
                        {
                            zacatek_x--;
                        }

                        temp1 = Math.Sqrt((zacatek_y - konec_y) * (zacatek_y - konec_y) + (zacatek_x - konec_x) * (zacatek_x - konec_x));
                       
                        if (temp1 < vzdalenost)
                        {
                            if (prekazky.Contains(labels[zacatek_y,zacatek_x]))
                            {
                                zacatek_x--;
                            }
                            else
                            {

                                JdeTo = true;
                                pocetkroku++;
                                vzdalenost = temp1;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                            }

                        }
                        else
                        {
                            zacatek_x--;
                        }
                    }                   
                    else if (i == 1)
                    {
                        zacatek_x--;
                        if (zacatek_x < 0)
                        {
                            zacatek_x++;
                        }

                        temp2 = Math.Sqrt((zacatek_y - konec_y) * (zacatek_y - konec_y) + (zacatek_x - konec_x) * (zacatek_x - konec_x));
                       
                        if (temp2 < vzdalenost)
                        {
                            if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                zacatek_x++;
                            }
                            else
                            {

                                JdeTo = true;
                                pocetkroku++;
                                vzdalenost = temp2;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                            }

                        }
                        else
                        {
                            zacatek_x++;
                        }
                    }
                    else if (i == 2)
                    {
                        zacatek_y++;
                        if (zacatek_y > 20)
                        {
                            zacatek_y--;
                        }

                        temp3 = Math.Sqrt((zacatek_y - konec_y) * (zacatek_y - konec_y) + (zacatek_x - konec_x) * (zacatek_x - konec_x));
                        
                        if (temp3 < vzdalenost)
                        {
                            if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                zacatek_y--;
                            }
                            else
                            {
                                JdeTo = true;
                                pocetkroku++;
                                vzdalenost = temp3;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                            }

                        }
                        else
                        {
                            zacatek_y--;
                        }
                    }
                    else if (i == 3)
                    {
                        zacatek_y--;
                        if (zacatek_y < 0)
                        {
                            zacatek_y++;
                        }

                        temp4 = Math.Sqrt((zacatek_y - konec_y) * (zacatek_y - konec_y) + (zacatek_x - konec_x) * (zacatek_x - konec_x));
                        
                        if (temp4 < vzdalenost)
                        {
                            if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                zacatek_y++;
                            }
                            else
                            {

                                JdeTo = true;
                                pocetkroku++;
                                vzdalenost = temp4;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;

                            }

                        }
                        else
                        {
                            zacatek_y++;
                        }
                    }
                    else if ((i == 4) && (!JdeTo))
                    {
                        //MessageBox.Show("got here");
                        double[] temporary = { temp1, temp2, temp3, temp4 };
                        double[] nejmensiVypocet = Find.lowest(temporary);
                        bool jde2cesta = false;
                        if (nejmensiVypocet[2] == temp1)
                        {
                            zacatek_x++;
                            if (!prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                
                                pocetkroku++;
                                vzdalenost = temp1;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                                jde2cesta = true;
                            }
                            else
                            {
                                zacatek_x--;
                            }
                            
                        }
                        else if (nejmensiVypocet[2] == temp2)
                        {
                           
                            zacatek_x--;
                            if (!prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                
                                pocetkroku++;
                                vzdalenost = temp2;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                                jde2cesta = true;
                            }
                            else
                            {
                                zacatek_x++;
                            }
                            

                        }
                        else if (nejmensiVypocet[2] == temp3)
                        {
                            
                            zacatek_y++;
                            if (!prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                
                                pocetkroku++;
                                vzdalenost = temp3;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                                jde2cesta = true;

                            }
                            else
                            {
                                zacatek_y--;
                            }
                            
                        }
                        else if (nejmensiVypocet[2] == temp4)
                        {
                            
                            zacatek_y--;
                            if (!prekazky.Contains(labels[zacatek_y, zacatek_x]))
                            {
                                
                                pocetkroku++;
                                vzdalenost = temp4;
                                Label label = labels[zacatek_y, zacatek_x];
                                prekazky.Add(label);
                                label.BackColor = Color.Orange;
                                jde2cesta = true;
                            }
                            else
                            {
                                zacatek_y++;
                            }
                           
                        }
                        else if (!jde2cesta)
                        {
                            MessageBox.Show("also got here");
                            if (nejmensiVypocet[3] == temp1)
                            {
                                zacatek_x++;
                                if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                                {

                                    pocetkroku++;
                                    vzdalenost = temp1;
                                    Label label = labels[zacatek_y, zacatek_x];
                                    prekazky.Add(label);
                                    label.BackColor = Color.Orange;
                                    jde2cesta = true;
                                }
                                zacatek_x--;
                            }
                            else if (nejmensiVypocet[3] == temp2)
                            {
                                zacatek_x--;
                                if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                                {

                                    pocetkroku++;
                                    vzdalenost = temp2;
                                    Label label = labels[zacatek_y, zacatek_x];
                                    prekazky.Add(label);
                                    label.BackColor = Color.Orange;
                                    jde2cesta = true;
                                }
                                zacatek_x++;

                            }
                            else if (nejmensiVypocet[3] == temp3)
                            {
                                zacatek_y++;
                                if (prekazky.Contains(labels[zacatek_y, zacatek_x]))
                                {

                                    pocetkroku++;
                                    vzdalenost = temp3;
                                    Label label = labels[zacatek_y, zacatek_x];
                                    prekazky.Add(label);
                                    label.BackColor = Color.Orange;
                                    jde2cesta = true;

                                }
                                zacatek_y--;
                            }
                            else if (nejmensiVypocet[3] == temp4)
                            {
                                zacatek_y--;
                                if (true)
                                {

                                    pocetkroku++;
                                    vzdalenost = temp4;
                                    Label label = labels[zacatek_y, zacatek_x];
                                    prekazky.Add(label);
                                    label.BackColor = Color.Orange;
                                    jde2cesta = true;
                                }
                                zacatek_y++;
                            }
                            else
                            {
                                MessageBox.Show("nope");
                            }
                        }
                        
                        //MessageBox.Show($"{temp1} : {nejmensiVypocet[2]}\n{temp2} : {nejmensiVypocet[2]}\n{temp3} : {nejmensiVypocet[2]}\n{temp4} : {nejmensiVypocet[2]}\n");

                    }





                }
                if (vzdalenost <= 1)
                {
                    watch.Stop();
                    info_cas.Text = watch.Elapsed.TotalMilliseconds.ToString() + "ms";
                    info_moves.Text = pocetkroku.ToString();
                    break;
                }
               
              
            }
        }

        public static void clear(Control.ControlCollection control){
            zacatek = false;
            konec = false;
            prekazky.Clear();
            foreach (object item in control)
            {
                if (item is Label)
                {
                    Label tempitem = (Label)item;
                    if (tempitem.BackColor != Color.LightGray)
                    {
                        tempitem.BackColor = Color.LightGray;
                    }
                }                
            }
        }

        public static void Start(MouseButtons key, Label label) {
            if (key == MouseButtons.Left)
            {
                if (!zacatek) {
                    label.BackColor = Color.Yellow;
                    zacatek_label = label;
                    
                    zacatek = true;
                }   
            }
            else if (key == MouseButtons.Right)
            {
                if (!konec)
                {
                    if (zacatek_label != label)
                    {
                        label.BackColor = Color.Red;

                        konec_label = label;
                        konec = true;
                    }   
                }           
            }
            else if (key == MouseButtons.Middle)
            {
                label.BackColor = Color.DarkBlue;
                prekazky.Add(label);
            }
        }
        public static double[] lowest(double[] array)
        {
            int n = array.Length;
            double firstmin = int.MaxValue;
            double secmin = int.MaxValue;
            double thirdmin = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                
                if (array[i] < firstmin)
                {
                    thirdmin = secmin;
                    secmin = firstmin;
                    firstmin = array[i];
                }

                
                else if (array[i] < secmin)
                {
                    thirdmin = secmin;
                    secmin = array[i];
                }

              
                else if (array[i] < thirdmin)
                    thirdmin = array[i];
            }











            double[] vysledek = { firstmin, secmin, thirdmin};
            return vysledek;
        }
       
    }
   





   
}
