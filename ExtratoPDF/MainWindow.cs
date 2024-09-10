using ClosedXML.Excel;
using ExtratoPDF.Extractors;
using ExtratoPDF.Models;
using System.CodeDom;
using System.Reflection;

namespace ExtratoPDF
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();

			listViewFiles.View = View.Details;
			listViewFiles.Columns.Clear();
			listViewFiles.Columns.Add("Arquivo", listViewFiles.Width - 110);
			listViewFiles.Columns.Add("Status", 100);


			listViewItems.View = View.Details;
			listViewItems.Columns.Clear();

			listViewItems.Columns.Add("Data", 100);
			listViewItems.Columns.Add("Descrição", listViewItems.Width - 310);
			listViewItems.Columns.Add("Valor", 100);
			listViewItems.Columns.Add("Arquivo", 100);

			LoadLibrary();

			UpdateButtonsStatus();

		}

		private void LoadLibrary()
		{
            statusApp.Text = Extrator.GetVersion();

            foreach (var item in Extrator.GetBankList())
            {
                comboBoxBank.Items.Add(item);
            }
        }

		private void buttonSelectFiles_Click(object sender, EventArgs e)
		{
			var result = openFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				listViewFiles.Items.Clear();
				listViewItems.Items.Clear();
				foreach (var file in openFileDialog.FileNames)
				{
					ListViewItem item = new(new string[] { Path.GetFileName(file), "Aguardando" });
					listViewFiles.Items.Add(item);
				}

				UpdateButtonsStatus();
			}
		}

		private void ProcessarFiles()
		{
			try
			{
				var files = openFileDialog.FileNames;

				listViewItems.Items.Clear();

				buttonProceess.Enabled = false;
				int indexFile = 0;
				foreach (var file in files)
				{
					buttonProceess.Text = $"{indexFile + 1}/{files.Count()}";
					string text = PDFConverter.Process(file);
					listViewFiles.Items[indexFile].EnsureVisible();


					var _items = Extrator.Extract(comboBoxBank.Text, text);

					UpdateArquivoStatus(file, $"[0/{_items.Count}]");
					int i = 0;
					_items.ForEach(item =>
					{

						ListViewItem listViewItem = new(new string[] {
							item.Date,
							item.Description,
							item.Value.ToString(),
							file
						});

						ListViewItem listItem = listViewItem;
						listViewItem.Tag = item;
						listViewItems.Items.Add(listItem);
						listItem.EnsureVisible();
						UpdateArquivoStatus(file, $"[{i}/{_items.Count}]");
						i++;
					});

					UpdateArquivoStatus(file, "Processado");
					indexFile++;
					//progreessBar.Value++;
				}

			}
			catch
			{
				MessageBox.Show("Erro ao tentar ler o PDF");
			}
			finally
			{
				buttonProceess.Text = "Processar";
				buttonProceess.Enabled = true;
				UpdateButtonsStatus();
			}
		}

		private void buttonCSV_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "CSV Files | *.csv";

			var result = saveFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				using StreamWriter sw = new(saveFileDialog.FileName);
				sw.WriteLine("Data;Descrição;Valor;Arquivo");

				foreach (ListViewItem itemView in listViewItems.Items)
				{
					if (itemView.Tag == null)
					{
						continue;
					}
					ExtratoItem item = (ExtratoItem)itemView.Tag;

					var _fileName = itemView.SubItems[3].Text;

					sw.WriteLine($"{item.Date};{item.Description};{item.Value};{Path.GetFileName(_fileName)}");
				}
				sw.Close();
			}
		}

		private void buttonEXCEL_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "Excel Files | *.xlsx";

			var result = saveFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;

				using (var workbook = new XLWorkbook())
				{
					var sheet = workbook.Worksheets.Add("Extrato");
					sheet.Cell("A1").Value = "Data";
					sheet.Cell("B1").Value = "Descri��o";
					sheet.Cell("C1").Value = "Valor";
					sheet.Cell("D1").Value = "Arquivo";

					var line = 2;

					foreach (ListViewItem itemView in listViewItems.Items)
					{
						if (itemView.Tag == null)
						{
							continue;
						}
						ExtratoItem item = (ExtratoItem)itemView.Tag;

						var _fileName = itemView.SubItems[3].Text;

						sheet.Cell("A" + line).Value = item.Date;
						sheet.Cell("B" + line).Value = item.Description;
						sheet.Cell("C" + line).Value = item.Value;
						sheet.Cell("D" + line).Value = Path.GetFileName(_fileName);
						line++;
					}

					workbook.SaveAs(fileName);
				}
			}
		}

		private void buttonProceess_Click(object sender, EventArgs e)
		{
			var t = new Thread(ProcessarFiles);
			t.Start();
		}

		private void UpdateButtonsStatus()
		{
			if (listViewItems.Items.Count == 0)
			{
				buttonCSV.Enabled = false;
				buttonExcel.Enabled = false;
			}
			else
			{
				buttonCSV.Enabled = true;
				buttonExcel.Enabled = true;
			}

			if (listViewFiles.Items.Count == 0)
			{
				buttonProceess.Enabled = false;
			}
			else
			{
				buttonProceess.Enabled = true;
			}
		}

		private void UpdateArquivoStatus(string file, string status)
		{
			foreach (ListViewItem item in listViewFiles.Items)
			{

				if (item.SubItems[0].Text == Path.GetFileName(file))
				{
					item.SubItems[1] = new(item, status);
				}
			}
		}

		private void listViewItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			UpdateButtonsStatus();
		}
	}
}
