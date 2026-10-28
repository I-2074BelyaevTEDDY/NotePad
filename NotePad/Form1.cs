
namespace NotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void richxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richxtbox.SelectionFont = fontDialog1.Font;
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Форматированный текст (*.rtf)|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richxtbox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Форматированный текст (*.rtf)|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richxtbox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.Clear();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richxtbox.CanUndo) richxtbox.Undo();
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.Cut();
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.Copy();
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.Paste();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.SelectedText = "";
        }
        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.WordWrap = !richxtbox.WordWrap;
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richxtbox.SelectAll();
        }
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = richxtbox.SelectionColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richxtbox.SelectionColor = colorDialog.Color;
                }
            }
        }
    }
}
