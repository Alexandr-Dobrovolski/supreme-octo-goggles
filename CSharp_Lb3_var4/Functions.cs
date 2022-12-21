using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Lb3_Var4
{
    public partial class FormFactory
    {
        //додавання інформації до ComboBox
        void addComboBoxInfo(ComboBox comboBox)
        {
            for (int i = 0; i < arr.Count; i++)
                comboBox.Items.Add(arr.ElementAt(i).factoryName);
        }

        //очищення форми після додавання інформації
        private void clearForm()
        {
            textBoxFactoryName.Text = "";
            textBoxNumberWorkshops.Text = "";
            textBoxAmountWorkers.Text = "";
            textBoxAmountCraftsmen.Text = "";
            textBoxProfitWorker.Text = "";
            textBoxProfitCraftsman.Text = "";
            textBoxCountDetais.Text = "";
        }

        //перевірка на повторюваність
        bool checkFactoriesRepeat(string factoryNameCheck)
        {
            bool result = false;

            if (arr.Count() != 0)
            {
                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr.ElementAt(i).factoryName == factoryNameCheck)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        //фукнція показу інформації на головному екрані за допомогою DataGridView
        public void addInfoToDataGridView(DataGridView dataGridView, int index, int statusWork)
        {
            HashSet<Factory> fArr = new HashSet<Factory>();

            if (statusWork == 1)
                fArr = arr;
            else
                fArr = arrCopy;

            dataGridView.Rows.Clear();
            dataGridView.Rows.Add("Назва заводу", fArr.ElementAt(index).factoryName);
            dataGridView.Rows.Add("К-сть цехів", fArr.ElementAt(index).numberWorkshops);
            dataGridView.Rows.Add("К-сть робітників", fArr.ElementAt(index).amountWorkers);
            dataGridView.Rows.Add("К-сть майстрів", fArr.ElementAt(index).amountCraftsmen);
            dataGridView.Rows.Add("Прибуток за 1 місяць з одного робітника", fArr.ElementAt(index).profitWorker);
            dataGridView.Rows.Add("Прибуток за 1 місяць з одного майстра", fArr.ElementAt(index).profitCraftman);
            dataGridView.Rows.Add("К-сть виготовлених деталей", fArr.ElementAt(index).countDetails);
        }

        //перевірка на правильність вводу податкового номера
        bool checkIndividualNumber(string individualNumber)
        {
            bool result = false;
            bool checkInFor;
            string number = "0123456789";
            for (int i = 0; i < individualNumber.Length; i++)
            {
                checkInFor = false;
                for (int j = 0; j < number.Length; j++)
                {
                    if (individualNumber[i] == number[j])
                    {
                        checkInFor = true;
                        break;
                    }
                }
                if (!checkInFor)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //перевірка на повторюваність індивідуального номера
        bool checkIndividualNumberRepeat(string individualNumber)
        {
            bool result = false;
            bool checkInFor;

            for (int i = 0; i < arr.Count; i++)
            {
                checkInFor = false;
                for (int j = 0; j < arr.ElementAt(i).listPeople.Count; j++)
                {
                    if (individualNumber == arr.ElementAt(i).listPeople[j].taxNumber)
                    {
                        checkInFor = true;
                        break;
                    }
                }
                if (checkInFor)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        //пошук працівника за його податковим номером
        int findPerson(string individualNumber)
        {
            int result = -1;

            for (int i = 0; i < arr.Count; i++)
            {
                bool inCycle = false;
                for (int j = 0; j < arr.ElementAt(i).listPeople.Count; j++)
                {
                    if (individualNumber == arr.ElementAt(i).listPeople[j].taxNumber)
                    {
                        inCycle = true;
                        break;
                    }
                }
                if (inCycle)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        //видалення співробітника
        void removePerson(int arrayIndex, int mode, string currentNumber)
        {
            if (mode == 1)
            {
                List<Worker> newWorkersList = new List<Worker>();
                for (int i = 0; i < arr.ElementAt(arrayIndex).listWorkers.Count; i++)
                {
                    if (currentNumber != arr.ElementAt(arrayIndex).listWorkers[i].taxNumber)
                        newWorkersList.Add(arr.ElementAt(arrayIndex).listWorkers[i]);
                }
                arr.ElementAt(arrayIndex).listWorkers = newWorkersList;
            }
            else
            {
                List<Master> newMastersList = new List<Master>();
                for (int i = 0; i < arr.ElementAt(arrayIndex).listWorkers.Count; i++)
                {
                    if (currentNumber != arr.ElementAt(arrayIndex).listMasters[i].taxNumber)
                        newMastersList.Add(arr.ElementAt(arrayIndex).listMasters[i]);
                }
                arr.ElementAt(arrayIndex).listMasters = newMastersList;
            }
            List<Person> newPeopleList = new List<Person>();
            for (int i = 0; i < arr.ElementAt(arrayIndex).listPeople.Count; i++)
            {
                if (currentNumber != arr.ElementAt(arrayIndex).listPeople[i].taxNumber)
                    newPeopleList.Add(arr.ElementAt(arrayIndex).listPeople[i]);
            }
            arr.ElementAt(arrayIndex).listPeople = newPeopleList;
        }
    }
}
