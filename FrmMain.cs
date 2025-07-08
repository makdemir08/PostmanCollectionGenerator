using Newtonsoft.Json;
using PostmanCollectionGenerator.Model;
using System.Text.RegularExpressions;

namespace PostmanCollectionGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "C# Controller Files (*.cs)|*.cs|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = ofd.FileName;
                    txtControllerName.Text = Path.GetFileNameWithoutExtension(ofd.FileName).Replace("Controller", "");
                }
            }
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Lütfen geçerli bir controller dosyası seçin.");
                return;
            }

            string code = File.ReadAllText(filePath);
            MatchCollection matches = Regex.Matches(code, @"public\s+\w+\s+(\w+)\s*\(");
            List<string> urls = new List<string>();

            foreach (Match match in matches)
            {
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    string methodName = match.Groups[i].Value;
                    urls.Add($"/{txtControllerName.Text}/{methodName}");
                }
            }

            var collection = new PostmanCollection
            {
                info = new Info
                {
                    name = txtControllerName.Text + " API",
                    schema = "https://schema.getpostman.com/json/collection/v2.1.0/collection.json"
                },
                item = new List<Item>()
            };

            foreach (var url in urls)
            {
                collection.item.Add(new Item
                {
                    name = url,
                    request = new Request
                    {
                        method = "GET",
                        url = new Url
                        {
                            raw = "https://localhost:5001" + url,
                            host = new[] { "localhost" },
                            path = url.Trim('/').Split('/')
                        },
                        header = new List<Header>()
                    },
                    response = new List<object>()
                });
            }

            string json = JsonConvert.SerializeObject(collection, Formatting.Indented);
            File.WriteAllText("collection.json", json);

            MessageBox.Show("collection.json başarıyla oluşturuldu!");
        }
    }
    
}
