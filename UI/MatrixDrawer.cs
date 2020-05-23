using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixLookup.UI
{
    class MatrixDrawer
    {
        static readonly int[,] DEFAULT_MATRIX = new int[4,4];

        readonly Point holder;
        readonly Control.ControlCollection controls;
        readonly Action<int, int, int> submit;
        public MatrixDrawer(Control control, Action<int,int,int> submit)
        {
            this.holder = control.Location;
            this.controls = control.Controls;
            this.submit = submit;
        }

        class MatrixInputElement : TextBox {
            public int i;
            public int j;
        }


        public void Draw(int[,] matrix)
        {
            Clear();

            matrix = (matrix == null)
                ? DEFAULT_MATRIX
                : matrix;

            var dx = holder.X + 80;
            var dy = holder.Y;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dx = holder.X + 10;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var textBox = new MatrixInputElement();
                    dx = dx + 25 + 5;
                    textBox.Width = 25;
                    textBox.Height = 25;
                    
                    textBox.Text = matrix[i, j].ToString();
                    textBox.Location = new Point(dx, dy + 30);
                    textBox.i = i;
                    textBox.j = j;
                    textBox.TextChanged += (object sender, EventArgs e) =>
                    {
                        var el = (sender as MatrixInputElement);
                        var value = 0;
                        if (Int32.TryParse(el.Text, out value))
                        {
                            this.submit(el.i, el.j, value);
                        }


                    };
                   
                    controls.Add(textBox);
                    
                }

                dy = dy + 30;
            }


        }

        private void Clear() {
            this.controls.Clear();
        }
    }
}
