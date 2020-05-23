using System;
using System.Windows.Forms;

namespace MatrixLookup
{
    public partial class MainForm : Form
    {
        private UI.MatrixDrawer drawer;
        private Random random = new Random(DateTime.Now.Millisecond);
        private int width = 2;
        private int height = 2;
        private int[,] currentMatrixRefference;
        public MainForm()
        {
            InitializeComponent();
           
            drawer = new UI.MatrixDrawer(this.gb_matrix_input, this.updateMatrix);

            this.tb_width.Text = width.ToString();
            this.tb_height.Text = height.ToString();
            drawer.Draw(new int[width, height]);
        }

        private int[,] GetMatrix(int x, int y) {
            if (x < 2) {
                x = 2;
            }
            if (y < 2)
            {
                y = 2;
            }

            return new int[x, y];
        }

        private void RedrawMatrix(Func<int> action) {
            var m = GetMatrix(width, height);
            currentMatrixRefference = m;
            if (action != null)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        m[i,j] = action();
                    }
                }
                
            }
            this.drawer.Draw(m);
        }

        private void onMatrixWidthChanged(object sender, EventArgs e)
        {
            doOnTextBox(sender, (text) => {
                try
                {
                    this.width = Int32.Parse(text);
                } catch (Exception ex) {

                    this.width = 2;
                }
                
            });
            RedrawMatrix(null);
        }

        private void onMatrixHeightChanged(object sender, EventArgs e)
        {
            doOnTextBox(sender, (text) => {
                try
                {
                    this.height = Int32.Parse(text);
                }
                catch (Exception ex)
                {

                    this.height = 2;
                }
            });
            RedrawMatrix(null);
        }

        private void doOnTextBox(object sender, Action<string> action) {
            if (!(sender is TextBox))
            {
                return;
            }
            var text = (sender as TextBox).Text;

            action.Invoke(text);
        }



        private void Btn_random_Click(object sender, EventArgs e)
        {
            RedrawMatrix(() => random.Next(-1, 13));
        }

        private void Btn_clean_output_Click(object sender, EventArgs e) {
            this.resultOutput.Text = "";
        }

        private void Btn_calculate_Click(object sender, EventArgs e)
        {
            MatrixSolver solver = new MatrixSolver(
                this.currentMatrixRefference, (msg) => {
                    this.resultOutput.Text += "\r\n" + msg;
                });
            solver.solve();
        }

        private void updateMatrix(int i, int j, int value) {
            try
            {
                this.currentMatrixRefference[i, j] = value;
            }
            catch (Exception e) {
            }
            
        }
    }
}
