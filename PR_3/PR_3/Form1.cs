using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxNumbersKeys.Clear();
            textBoxNumbersValues.Clear();
            textBoxNumbersExScreen.Clear();
            errorProviderNull.Clear();
            errorProviderSymbol.Clear();
            errorProviderNumberCharacters.Clear();
        }

        private void Generation_Click(object sender, EventArgs e)
        {
            errorProviderNull.Clear();
            errorProviderSymbol.Clear();
            errorProviderNumberCharacters.Clear();

            Dictionary<int, int> randomKeys = new Dictionary<int, int>(); // Создаём словарь
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int key = rand.Next(1, 11);

                while (randomKeys.ContainsKey(key)) // Проверка на наличие ключа в словаре -> иначе ошибка что уже до этого созданы*
                {
                    key = rand.Next(1, 11);
                }

                randomKeys.Add(key, key); // Для дальнейшего вывода только ключей
            }

            string keysExit = String.Join(" ", randomKeys.Keys); // Преобразуем ТОЛЬКО КЛЮЧИ в строку через пробел
            textBoxNumbersKeys.Text = keysExit; // Выводим строку с ключами в текстовое поле
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            string input = textBoxNumbersValues.Text;
            string[] numbersArray = input.Split(' '); // Разбиваем строку на отдельные числа

            int result = 1; // Инициализируем результат умножения

            foreach (string numStr in numbersArray)
            {
                int number;
                if (int.TryParse(numStr, out number)) // Пытаемся преобразовать строку в число
                {
                    result *= number; // Умножаем значение на результат
                }
            }
            if (result == 1) textBoxNumbersExScreen.Text = "Ошибка. Нет значений."; // Выводим результат умножения в текстовое поле
            else textBoxNumbersExScreen.Text = result.ToString(); // Выводим результат умножения в текстовое поле
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            textBoxNumbersKeys.Clear();
            textBoxNumbersValues.Clear();
            textBoxNumbersExScreen.Clear();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ApplicationGeneration_Click(object sender, EventArgs e)
        {
            Generation_Click(sender, e);
        }

        private void ApplicationMultiply_Click(object sender, EventArgs e)
        {
            Multiply_Click(sender, e);
        }

        private void textBoxNumbersKeys_TextChanged(object sender, EventArgs e) // Ошибочки №194
        {
            try
            {
                int inputNumbers;
                if (string.IsNullOrWhiteSpace(textBoxNumbersKeys.Text))   // Проверяем, что строка не является пустой -> иначе выводится ошибка что значения не целочисленные :(
                {
                    errorProviderSymbol.Clear();
                    return;
                }
                string input = textBoxNumbersValues.Text;
                string[] numbersArray = input.Split(' '); // Разбиваем строку на отдельные числа -> иначе выводит не так как нужно.
                if (!int.TryParse(textBoxNumbersKeys.Text, out inputNumbers)) errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Пожалуйста, введите целочисленное значение.");
                else if (inputNumbers > 10) errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Значения ключей не должны превышать 10.");
                else if (inputNumbers < 1) errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Значения ключей не должны быть меньше 1");
                else
                {
                    errorProviderSymbol.Clear(); // очистка данных при устран
                }

                string keysExit = textBoxNumbersKeys.Text; // Получаем строку с ключами из текстового поля
                string[] keysArray = keysExit.Split(' '); // Разбиваем строку на подстроки, некий массив ключей
                Dictionary<int, int> randomKeys = new Dictionary<int, int>(); // Создаем новый словарь (2-ой) для хранения ключей и их кубов

                foreach (string keyString in keysArray)
                {
                    int key = Convert.ToInt32(keyString); // создаём переменную ключ и после в нём преобразуем строки/уже созданные ранее ключи в целочисленное значение
                    int valueKeyX3 = key * key * key; // Значение (value) получаем возводя ключ в куб
                    randomKeys.Add(key, valueKeyX3); // Добавляем ключ и его куб в словарь
                }

                string result = String.Join(" ", randomKeys.Values); // Преобразуем значения (кубы ключей) в строку через пробел
                textBoxNumbersValues.Text = result; // Выводим строку с кубами в текстовое поле

                foreach (string keyString in keysArray)
                {
                    int key = Convert.ToInt32(keyString); // создаём переменную ключ и после в нём преобразуем строки/уже созданные ранее ключи в целочисленное значение
                    int valueKey = key; // Значение (value) получаем возводя ключ в куб
                    randomKeys.Add(key, valueKey); // Добавляем ключ и его куб в словарь
                }

                textBoxNumbersValues.Text = result; // Выводим строку с кубами в текстовое поле
            }
            catch
            {
                int inputNumbers;
                if (string.IsNullOrWhiteSpace(textBoxNumbersKeys.Text))   // Проверяем, что строка не является пустой -> иначе выводится ошибка что значения не целочисленные :(
                {
                    errorProviderSymbol.Clear();
                    return;
                }
                if (!int.TryParse(textBoxNumbersKeys.Text, out inputNumbers)) errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Пожалуйста, введите целочисленное значение.");
                else
                {
                    errorProviderSymbol.Clear();
                }
            }
        }

        private void textBoxNumbersKeys_Leave(object sender, EventArgs e) // создано лично с целью очистки ошибки через Form1
        {
            errorProviderSymbol.Clear();
        }

        private void textBoxNumbersValues_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNumbersKeys.TextChanged += textBoxNumbersKeys_TextChanged;
            textBoxNumbersKeys.Leave += textBoxNumbersKeys_Leave;
        }

        private void Cubing_Click(object sender, EventArgs e)
        {
            try
            {
                errorProviderNull.Clear();
                errorProviderSymbol.Clear();
                errorProviderNumberCharacters.Clear();

                string keysExit = textBoxNumbersKeys.Text; // Получаем строку с ключами из текстового поля
                string[] keysArray = keysExit.Split(' '); // Разбиваем строку на подстроки, некий массив ключей
                Dictionary<int, int> randomKeys = new Dictionary<int, int>(); // Создаем новый словарь (2-ой) для хранения ключей и их кубов

                foreach (string keyString in keysArray)
                {
                   int key = Convert.ToInt32(keyString); // создаём переменную ключ и после в нём преобразуем строки/уже созданные ранее ключи в целочисленное значение
                   int valueKeyX3 = key * key * key; // Значение (value) получаем возводя ключ в куб
                   randomKeys.Add(key, valueKeyX3); // Добавляем ключ и его куб в словарь
                }

                string result = String.Join(" ", randomKeys.Values); // Преобразуем значения (кубы ключей) в строку через пробел
                textBoxNumbersValues.Text = result; // Выводим строку с кубами в текстовое поле
            }
            catch
            {
                MessageBox.Show("Нет данных. Введите или сгенерируйте валидные ключи для возведения в куб"); // Выводим результат в сообщении, довольно интересная тема на будущие работы >:З
                int inputNumber;
                if (!Int32.TryParse(textBoxNumbersKeys.Text, out inputNumber)) errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Пожалуйста, введите целочисленное значение.");
                if(textBoxNumbersKeys.Text == null) {errorProviderSymbol.SetError(textBoxNumbersKeys, "Ошибка. Пожалуйста, введите сюда штонить");}
            }
        }

        private void textBoxNumbersExScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationCubing_Click(object sender, EventArgs e)
        {
            Cubing_Click(sender, e);
        }

        private void Reference_Click(object sender, EventArgs e)
        {

        }

        private void Dictionary_Enter(object sender, EventArgs e)
        {

        }
    }
}