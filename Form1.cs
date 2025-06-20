using NCalc;
using Newtonsoft.Json;
using ScottPlot.Plottables;
using System.Globalization;

namespace WinFormsPractice
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            var floatingX = new FloatingAxis(this.formsPlot1.Plot.Axes.Bottom);
            var floatingY = new FloatingAxis(this.formsPlot1.Plot.Axes.Left);

            this.formsPlot1.Plot.Add.Plottable(floatingX);
            this.formsPlot1.Plot.Add.Plottable(floatingY);

            this.formsPlot1.Plot.Axes.Bottom.Label.Text = "Y";
            this.formsPlot1.Plot.Axes.Left.Label.Text = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(this.textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double step) ||
             !double.TryParse(this.textBox3.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double min) ||
             !double.TryParse(this.textBox4.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double max))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення для кроку, мінімуму та максимуму.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (step <= 0)
            {
                MessageBox.Show("Крок має бути додатним числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (min >= max)
            {
                MessageBox.Show("Мінімум має бути меншим за максимум.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dataX = new List<double>();
            var dataY = new List<double>();

            for (double x = min; x <= max; x += step)
            {
                double y = double.NaN;
                if (x > 4.0 && x < 5.0)
                {
                    y = (Math.Sqrt(5 + Math.Pow(x, 4.0)) +
                        Math.Pow(Math.Log(2.0 * x), 2.0) / (1.2 + Math.Pow(x, 3.0))) * Math.Cos(x);
                }
                else if (x > -6.0 && x < -1.0)
                {
                    y = Math.Pow(x, -22.0) - 1.0;
                }
                else
                {
                    y = 5.0 + Math.Pow(x, 5.0);
                }

                dataX.Add(x);
                dataY.Add(y);
            }

            this.AddPlot(new Graphic
            {
                DataX = dataX.ToArray(),
                DataY = dataY.ToArray()
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var step = double.Parse(this.textBox2.Text, CultureInfo.InvariantCulture);
            var min = double.Parse(this.textBox3.Text, CultureInfo.InvariantCulture);
            var max = double.Parse(this.textBox4.Text, CultureInfo.InvariantCulture);

            var formula = this.textBox1.Text;
            var expression = new Expression(formula);

            var dataX = new List<double>();
            var dataY = new List<double>();

            try
            {
                for (double x = min; x <= max; x += step)
                {
                    expression.Parameters["x"] = x;
                    var y = (double)expression.Evaluate();
                    dataX.Add(x);
                    dataY.Add(y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error evaluating expression: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.AddPlot(new Graphic
            {
                DataX = dataX.ToArray(),
                DataY = dataY.ToArray()
            });
        }

        private void button3_Click(object sender, EventArgs e) => this.PlotMove(0.0, 1.0);

        private void button4_Click(object sender, EventArgs e) => this.PlotMove(0.0, -1.0);

        private void button5_Click(object sender, EventArgs e) => this.PlotMove(-1.0, 0.0);

        private void button6_Click(object sender, EventArgs e) => this.PlotMove(1.0, 0.0);

        private void PlotMove(double dx, double dy)
        {
            var plot = this.formsPlot1.Plot;
            foreach (var item in plot.GetPlottables())
            {
                var scatter = item as Scatter;
                if (scatter is null)
                {
                    continue;
                }

                scatter.OffsetX += dx;
                scatter.OffsetY += dy;
            }

            this.formsPlot1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e) => this.PlotScale(0.0, 0.1);

        private void button7_Click(object sender, EventArgs e) => this.PlotScale(0.0, -0.1);

        private void button9_Click(object sender, EventArgs e) => this.PlotScale(-0.1, 0.0);

        private void button10_Click(object sender, EventArgs e) => this.PlotScale(0.1, 0.0);

        private void PlotScale(double dx, double dy)
        {
            var plot = this.formsPlot1.Plot;
            foreach (var item in plot.GetPlottables())
            {
                var scatter = item as Scatter;
                if (scatter is null)
                {
                    continue;
                }

                scatter.ScaleX += dx;
                scatter.ScaleY += dy;
            }

            this.formsPlot1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog
            {
                Filter = "json files (*.json)|*.json",
            };

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var filePath = fileDialog.FileName;
            var fileStream = fileDialog.OpenFile();

            using var reader = new StreamReader(fileStream);
            var fileContent = reader.ReadToEnd();
            var data = JsonConvert.DeserializeObject<Graphic>(fileContent);

            this.AddPlot(data);
        }

        private void AddPlot(Graphic graphic)
        {
            var scatter = this.formsPlot1.Plot.Add.Scatter(graphic.DataX, graphic.DataY);
            scatter.LegendText = $"f{Form1.PlotIndex++}(x)";
            this.formsPlot1.Refresh();
        }

        private static int PlotIndex = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
