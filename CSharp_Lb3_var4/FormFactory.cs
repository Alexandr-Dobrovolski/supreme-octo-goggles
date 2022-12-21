using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lb3_Var4
{
    public partial class FormFactory : Form
    {
        HashSet<Factory> arr, arrCopy;

        public FormFactory()
        {
            InitializeComponent();
            arr = new HashSet<Factory>();
            arrCopy = new HashSet<Factory>();

            if (!Directory.Exists("FactoryData"))
                Directory.CreateDirectory("FactoryData");
            else
            {
                var directories = Directory.GetDirectories("FactoryData");
                List<Worker> newListWorkers = new List<Worker>();
                List<Person> newListPeople = new List<Person>();
                List<Master> newListMasters = new List<Master>();
                for (int i = 0; i < directories.Length; i++)
                {
                    Factory readFactory = new Factory();
                    StreamReader FactoryReader = new StreamReader(directories[i] + "\\Factory.txt");
                    int countLine = 0;
                    while (!FactoryReader.EndOfStream)
                    {
                        switch(countLine)
                        {
                            case 0:
                                readFactory.factoryName = FactoryReader.ReadLine();
                                countLine++;
                                break;
                            case 1:
                                int parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.numberWorkshops = parse;
                                countLine++;
                                break;
                            case 2:
                                parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.amountWorkers = parse;
                                countLine++;
                                break;
                            case 3:
                                parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.amountCraftsmen = parse;
                                countLine++;
                                break;
                            case 4:
                                parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.profitWorker = parse;
                                countLine++;
                                break;
                            case 5:
                                parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.profitCraftman = parse;
                                countLine++;
                                break;
                            case 6:
                                parse = Int32.Parse(FactoryReader.ReadLine());
                                readFactory.countDetails = parse;
                                countLine++;
                                break;
                        }
                    }
                    FactoryReader.Close();

                    //Workers.txt
                    Worker newWorker = new Worker();
                    Person newPerson = new Person();
                    StreamReader WorkersReader = new StreamReader(directories[i] + "\\Workers.txt");
                    countLine = 0;
                    while (!WorkersReader.EndOfStream)
                    {
                        switch (countLine)
                        {
                            case 0:
                                newWorker.surname = WorkersReader.ReadLine();
                                newPerson.surname = newWorker.surname;
                                countLine++;
                                break;
                            case 1:
                                newWorker.name = WorkersReader.ReadLine();
                                newPerson.name = newWorker.name;
                                countLine++;
                                break;
                            case 2:
                                newWorker.patronymic = WorkersReader.ReadLine();
                                newPerson.patronymic = newWorker.patronymic;
                                countLine++;
                                break;
                            case 3:
                                newWorker.taxNumber = WorkersReader.ReadLine();
                                newPerson.taxNumber = newWorker.taxNumber;
                                countLine++;
                                break;
                            case 4:
                                int parse = Int32.Parse(WorkersReader.ReadLine());
                                newWorker.numberWorkshop = parse;
                                newPerson.numberWorkshop = parse;
                                countLine++;
                                break;
                            case 5:
                                if (WorkersReader.ReadLine() == "True")
                                    newWorker.haveHigherTechnicalEducation = true;
                                else
                                    newWorker.haveHigherTechnicalEducation = false;
                                countLine++;
                                break;
                            case 6:
                                WorkersReader.ReadLine();
                                newListWorkers.Add(newWorker);
                                newListPeople.Add(newPerson);
                                newWorker = new Worker();
                                newPerson = new Person();
                                countLine = 0;
                                break;
                        }
                    }
                    WorkersReader.Close();

                    //Masters.txt
                    Master newMaster = new Master(); 
                    StreamReader MastersReader = new StreamReader(directories[i] + "\\Masters.txt");
                    countLine = 0;
                    while (!MastersReader.EndOfStream)
                    {
                        switch (countLine)
                        {
                            case 0:
                                newMaster.surname = MastersReader.ReadLine();
                                newPerson.surname = newMaster.surname;
                                countLine++;
                                break;
                            case 1:
                                newMaster.name = MastersReader.ReadLine();
                                newPerson.name = newMaster.name;
                                countLine++;
                                break;
                            case 2:
                                newMaster.patronymic = MastersReader.ReadLine();
                                newPerson.patronymic = newMaster.patronymic;
                                countLine++;
                                break;
                            case 3:
                                newMaster.taxNumber = MastersReader.ReadLine();
                                newPerson.taxNumber = newMaster.taxNumber;
                                countLine++;
                                break;
                            case 4:
                                int parse = Int32.Parse(MastersReader.ReadLine());
                                newMaster.numberWorkshop = parse;
                                newPerson.numberWorkshop = parse;
                                countLine++;
                                break;
                            case 5:
                                parse = Int32.Parse(MastersReader.ReadLine());
                                newMaster.countCertificates = parse;
                                countLine++;
                                break;
                            case 6:
                                MastersReader.ReadLine();
                                newListMasters.Add(newMaster);
                                newListPeople.Add(newPerson);
                                newMaster = new Master();
                                newPerson = new Person();
                                countLine = 0;
                                break;
                        }
                    }
                    MastersReader.Close();
                    readFactory.listWorkers = newListWorkers;
                    readFactory.listMasters = newListMasters;
                    readFactory.listPeople = newListPeople;

                    arr.Add(readFactory);
                    comboBoxFactories.Items.Add(readFactory.factoryName);
                    readFactory = new Factory();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Directory.CreateDirectory("FactoryData\\" + arr.ElementAt(i).factoryName);
                //Factory.txt
                string strSave = arr.ElementAt(i).factoryName + '\n'
                    + arr.ElementAt(i).numberWorkshops + '\n'
                    + arr.ElementAt(i).amountWorkers + '\n'
                    + arr.ElementAt(i).amountCraftsmen + '\n'
                    + arr.ElementAt(i).profitWorker + '\n'
                    + arr.ElementAt(i).profitCraftman + '\n'
                    + arr.ElementAt(i).countDetails;
                File.WriteAllText("FactoryData\\" + arr.ElementAt(i).factoryName + "\\Factory.txt", strSave);
                //Workers.txt
                strSave = "";
                for (int j = 0; j < arr.ElementAt(i).listWorkers.Count; j++)
                {
                    strSave += arr.ElementAt(i).listWorkers[j].surname + '\n'
                        + arr.ElementAt(i).listWorkers[j].name + '\n'
                        + arr.ElementAt(i).listWorkers[j].patronymic + '\n'
                        + arr.ElementAt(i).listWorkers[j].taxNumber + '\n'
                        + arr.ElementAt(i).listWorkers[j].numberWorkshop + '\n'
                        + arr.ElementAt(i).listWorkers[j].haveHigherTechnicalEducation + "\n\n";
                }
                File.WriteAllText("FactoryData\\" + arr.ElementAt(i).factoryName + "\\Workers.txt", strSave);

                //Masters.txt
                strSave = "";
                for (int j = 0; j < arr.ElementAt(i).listMasters.Count; j++)
                {
                    strSave += arr.ElementAt(i).listMasters[j].surname + '\n'
                        + arr.ElementAt(i).listMasters[j].name + '\n'
                        + arr.ElementAt(i).listMasters[j].patronymic + '\n'
                        + arr.ElementAt(i).listMasters[j].taxNumber + '\n'
                        + arr.ElementAt(i).listMasters[j].numberWorkshop + '\n'
                        + arr.ElementAt(i).listMasters[j].countCertificates + "\n\n";
                }
                File.WriteAllText("FactoryData\\" + arr.ElementAt(i).factoryName + "\\Masters.txt", strSave);
            }
            Application.Exit();
        }

        private void hiringWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeFormHiring(1, "Add", true, 0, 1);
            comboBoxFactories.SelectedIndex = -1;
        }

        private void hiringCraftsmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeFormHiring(2, "Add", true, 0, 1);
            comboBoxFactories.SelectedIndex = -1;
        }

        private void firingWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeFormFiring(1);
        }

        private void firingCraftsmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeFormFiring(2);
        }

        private void copyFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arr.Count() == 0)
                MessageBox.Show("Ви ще не додали жодного заводу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxFactories.SelectedIndex == -1)
                MessageBox.Show("Оберіть завод зі списку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                arrCopy.Add(new Factory(arr.ElementAt(comboBoxFactories.SelectedIndex)));
                MessageBox.Show("Успішне копіювання!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxFactoriesCopy.Items.Add(arrCopy.ElementAt(arrCopy.Count() - 1).factoryName);
                comboBoxFactories.SelectedIndex = -1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFactoryName.Text == "" || textBoxNumberWorkshops.Text == "" ||
                textBoxAmountWorkers.Text == "" || textBoxAmountCraftsmen.Text == "" ||
                textBoxProfitWorker.Text == "" || textBoxProfitCraftsman.Text == "")
                MessageBox.Show("Недостатньо даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool checkRepeat = checkFactoriesRepeat(textBoxFactoryName.Text);
                if (checkRepeat)
                    MessageBox.Show("Такий завод вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int tempNumberWorkshops, tempAmountWorkers, tempAmountCraftsmen, tempProfitWorker, tempProfitCraftman, tempCountDetais;
                    Int32.TryParse(textBoxNumberWorkshops.Text, out tempNumberWorkshops);
                    Int32.TryParse(textBoxAmountWorkers.Text, out tempAmountWorkers);
                    Int32.TryParse(textBoxAmountCraftsmen.Text, out tempAmountCraftsmen);
                    Int32.TryParse(textBoxProfitWorker.Text, out tempProfitWorker);
                    Int32.TryParse(textBoxProfitCraftsman.Text, out tempProfitCraftman);
                    Int32.TryParse(textBoxCountDetais.Text, out tempCountDetais);
                    if (tempNumberWorkshops <= 0)
                        MessageBox.Show("Неправильна вказана кількість цехів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempAmountWorkers <= 0)
                        MessageBox.Show("Неправильна вказана кількість робітників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempAmountCraftsmen <= 0)
                        MessageBox.Show("Неправильна вказана кількість майстрів", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempProfitWorker == 0)
                        MessageBox.Show("Неправильно вказаний прибуток з одного робітника!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempProfitCraftman == 0)
                        MessageBox.Show("Неправильно вказаний прибуток з одного майстра!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempAmountCraftsmen * 10 < tempAmountWorkers)
                        MessageBox.Show("Недостатньо майстрів! Один майстер на 10 робітників.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tempCountDetais <= 0)
                        MessageBox.Show("Не правильний формат кількості деталей!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Factory temp = new Factory();
                        temp.factoryName = textBoxFactoryName.Text;
                        temp.numberWorkshops = tempNumberWorkshops;
                        temp.amountWorkers = tempAmountWorkers;
                        temp.amountCraftsmen = tempAmountCraftsmen;
                        temp.profitWorker = tempProfitWorker;
                        temp.profitCraftman = tempProfitCraftman;
                        temp.countDetails = tempCountDetais;
                        arr.Add(temp);
                        comboBoxFactories.Items.Add(temp.factoryName);
                        initializeFormHiring(1, "New", false, arr.Count - 1, tempAmountWorkers);
                        initializeFormHiring(2, "New", false, arr.Count - 1, tempAmountCraftsmen);
                        clearForm();
                    }
                }
            }
        }

        private void buttonShowCopy_Click(object sender, EventArgs e)
        {
            if (arrCopy.Count() == 0)
                MessageBox.Show("Ви ще не скопіювали жодного заводу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxFactoriesCopy.SelectedIndex == -1)
                MessageBox.Show("Оберіть скопійований завод зі списку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addInfoToDataGridView(dataGridView1, comboBoxFactoriesCopy.SelectedIndex, 2);
                comboBoxFactoriesCopy.SelectedIndex = -1;
            }

        }

        private void comparisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arr.Count() < 2)
                MessageBox.Show("Недостатня кількість заводів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                initializeFormComparison();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (arr.Count() == 0)
                MessageBox.Show("Ви ще не додали жодного заводу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxFactories.SelectedIndex == -1)
                MessageBox.Show("Оберіть завод зі списку!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addInfoToDataGridView(dataGridView1, comboBoxFactories.SelectedIndex, 1);
                comboBoxFactories.SelectedIndex = -1;
            }
        }
    }
}
