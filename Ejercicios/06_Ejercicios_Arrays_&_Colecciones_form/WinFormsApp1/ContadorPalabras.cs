using System.Text;
using System.Text.RegularExpressions;

namespace Contador
{
    public partial class ContadorPalabras : Form
    {
        public ContadorPalabras()
        {
            InitializeComponent();
        }

        // Buttons
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (string word in Regex.Split(this.rtbPalabras.Text.Trim(), @"[\n ]+"))
            {
                if (countWords.ContainsKey(word)) { countWords[word]++; }
                else { countWords.Add(word, 1); }
            }
            MessageBox.Show($"{this.GetTopWords(countWords)}", "Top palabras", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Methods
        private StringBuilder GetTopWords(Dictionary<string, int> dict)
        {
            StringBuilder sb = new StringBuilder();
            List<KeyValuePair<string, int>> listDict = dict.ToList(); // Casteo el diccionario en un keyvaluepair
            listDict.Sort((x, y) => y.Value.CompareTo(x.Value)); // Uso compareTo para comparar los valores y saber cual es mayor

            // Loopeo por la longitud para que no rompp. Corto en top 3
            for (int i = 0; i < listDict.Count; i++)
            {
                if (i >= 3) { break; }
                sb.Append($"\n • \"{listDict[i].Key}\" -> Usada {listDict[i].Value} veces");
            }
            return sb;
        }
    }
}