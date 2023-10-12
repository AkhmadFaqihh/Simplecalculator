namespace Simplecalculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Konstruktor untuk Form1.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler peristiwa saat Form1 dimuat.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler peristiwa saat label3 diklik.
        /// </summary>
        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler peristiwa saat textBox2 diubah.
        /// </summary>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handler peristiwa saat label1 diklik.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handler peristiwa saat textBox1 diubah.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handler peristiwa saat label2 diklik.
        /// </summary>
        private void label2_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handler peristiwa saat textBox3 diubah.
        /// </summary>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Operasi penjumlahan dua angka yang dimasukkan ke dalam textBox1 dan textBox2.
        /// Hasilnya ditampilkan di textBox3.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 + txt2;

            textBox3.Text = sum.ToString();
        }

        /// <summary>
        /// Operasi pengurangan dua angka yang dimasukkan ke dalam textBox1 dan textBox2.
        /// Hasilnya ditampilkan di textBox3.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 - txt2;

            textBox3.Text = sum.ToString();
        }

        /// <summary>
        /// Operasi pembagian dua angka yang dimasukkan ke dalam textBox1 dan textBox2.
        /// Hasilnya ditampilkan di textBox3.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 / txt2;

            textBox3.Text = sum.ToString();
        }

        /// <summary>
        /// Operasi perkalian dua angka yang dimasukkan ke dalam textBox1 dan textBox2.
        /// Hasilnya ditampilkan di textBox3.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 * txt2;

            textBox3.Text = sum.ToString();
        }
    }
}
