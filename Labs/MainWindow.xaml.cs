using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string textTask;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tasksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textTask = tasksComboBox.SelectedItem.ToString().Substring(38);
            answer.Content = "Ответ:";
            answer.Visibility = Visibility.Visible;
            sidesInt.Visibility = Visibility.Collapsed;
            sides.Visibility = Visibility.Collapsed;
            changeSides.Visibility = Visibility.Collapsed;
            switch (textTask)
            {
                case "Lab 1: Задание 1. Методы: 1":
                    task.Content = "Дробная часть.\r\nДана сигнатура метода: public double fraction (double x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nтолько дробную часть числа х. Подсказка: вещественное число\r\nможет быть преобразовано к целому путем отбрасывания дробной части.\r\n\r\nПример:\r\nx=5,25\r\nрезультат: 0,25\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 1. Методы: 3":
                    task.Content = "Букву в число.\r\nДана сигнатура метода: public int charToNum (char x); Метод\r\nпринимает символ х, который представляет собой один из\r\n“0 1 2 3 4 5 6 7 8 9”. Необходимо реализовать метод таким образом,\r\nчтобы он преобразовывал символ в соответствующее число. Подсказка:\r\nкод символа ‘0’ — это число 48.\r\n\r\nПример:\r\nx=’3’\r\nрезультат: 3\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 1. Методы: 5":
                    task.Content = "Двузначное.\r\nДана сигнатура метода: public bool is2Digits (int x); Необходимо\r\nреализовать метод таким образом, чтобы он принимал число x\r\nи возвращал true, если оно двузначное.\r\n\r\nПример 1:\r\nx=32\r\nрезультат: true\r\n\r\nПример 2:\r\nx=516\r\nрезультат: false";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Hidden);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 1. Методы: 7":
                    task.Content = "Диапазон.\r\nДана сигнатура метода: public bool isInRange (int a, int b, int num);\r\nМетод принимает левую и правую границу (a и b) некоторого\r\nчислового диапазона. Необходимо реализовать метод таким образом,\r\nчтобы он возвращал true, если num входит в указанный диапазон\r\n(включая границы). Обратите внимание, что отношение a и b заранее\r\nнеизвестно (неясно кто из них больше, а кто меньше)\r\n\r\nПример 1:\r\na=5 b=1 num=3\r\nрезультат: true\r\n\r\nПример 2:\r\na=2 b=15 num=33\r\nрезультат: false\r\n";
                    ValueText("a =", "b =", "num =");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 1. Методы: 9":
                    task.Content = "Равенство.\r\nДана сигнатура метода: public bool isEqual(int a, int b, int c);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\ntrue, если все три полученных методом числа равны\r\n\r\nПример 1:\r\na=3 b=3 с=3\r\nрезультат: true\r\n\r\nПример 2:\r\na=2 b=15 с=2\r\nрезультат: false";
                    ValueText("a =", "b =", "c =");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 2. Условия: 1":
                    task.Content = "Модуль числа.\r\nДана сигнатура метода: public int abs (int x); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал модуль числа х\r\n(если оно было положительным, то таким и остается, если он было\r\nотрицательным – то необходимо вернуть его без знака минус).\r\n\r\nПример 1:\r\nx=5\r\nрезультат: 5\r\n\r\nПример 2:\r\nx=-3\r\nрезультат: 3";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Hidden);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 2. Условия: 3":
                    task.Content = "Тридцать пять.\r\nДана сигнатура метода: public bool is35 (int x); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал true, если\r\nчисло x делится нацело на 3 или 5. При этом, если оно делится\r\nи на 3, и на 5, то вернуть надо false. Подсказка: оператор %\r\nпозволяет получить остаток от деления.\r\n\r\nПример 1:\r\nx=5\r\nрезультат: true\r\n\r\nПример 2:\r\nx=8\r\nрезультат: false\r\nПример 3:\r\nx=15\r\nрезультат: false";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Hidden, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 2. Условия: 5":
                    task.Content = "Тройной максимум.\r\nДана сигнатура метода: public int max3 (int x, int y, int z);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nмаксимальное из трех полученных методом чисел. Подсказка: идеальное\r\nрешение включает всего две инструкции if и не содержит вложенных if.\r\n\r\nПример 1:\r\nx=5 y=7 z=7\r\nрезультат: 7\r\n\r\nПример 2:\r\nx=8 y=-1 z=4\r\nрезультат: 8";
                    ValueText("x =", "y =", "z =");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 2. Условия: 7":
                    task.Content = "Двойная сумма.\r\nДана сигнатура метода: public int sum2 (int x, int y); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал сумму чисел\r\nx и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо\r\nвернуть число 20.\r\n\r\nПример 1:\r\nx=5 y=7\r\nрезультат: 20\r\n\r\nПример 2:\r\nx=8 y=-1\r\nрезультат: 7";
                    ValueText("x =", "y =", "");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 2. Условия: 9":
                    task.Content = "День недели.\r\nДана сигнатура метода: public String day (int x); Метод принимает\r\nчисло x, обозначающее день недели. Необходимо реализовать метод\r\nтаким образом, чтобы он возвращал строку, которая будет обозначать\r\nтекущий день недели, где 1 - это понедельник, а 7 – воскресенье.\r\nЕсли число не от 1 до 7 то верните текст “это не день недели”.\r\nВместо if в данной задаче используйте switch.\r\n\r\nПример:\r\nx=5\r\nрезультат: “пятница”\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 3. Циклы: 1":
                    task.Content = "Числа подряд.\r\nДана сигнатура метода: public String listNums (int x); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал строку, в\r\nкоторой будут записаны все числа от 0 до x (включительно).\r\n\r\nПример:\r\nx=5\r\nрезультат: “0 1 2 3 4 5”";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 3. Циклы: 3":
                    task.Content = "Четные числа.\r\nДана сигнатура метода: public String chet (int x); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал строку, в\r\nкоторой будут записаны все четные числа от 0 до x (включительно).\r\nПодсказа для обеспечения качества кода: инструкцию if использовать\r\nне следует.\r\n\r\nПример:\r\nx=9\r\nрезультат: “0 2 4 6 8”\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 3. Циклы: 5":
                    task.Content = "Длина числа.\r\nДана сигнатура метода: public int numLen (long x); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал количество\r\nзнаков в числе x.\r\nПодсказка:\r\nInt у=123/10; // у будет иметь значение 12\r\n\r\nПример:\r\nx=12567\r\nрезультат: 5\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 3. Циклы: 7":
                    task.Content = "Квадрат.\r\nДана сигнатура метода: public void square (int x); Необходимо\r\nреализовать метод таким образом, чтобы он выводил на экран квадрат\r\nиз символов ‘*’ размером х, у которого х символов в ряд и х\r\nсимволов в высоту.\r\n\r\nПример 1:\r\nx=2\r\nрезультат:\r\n**\r\n**\r\n\r\nПример 2:\r\nx=4\r\nрезультат:\r\n****\r\n****\r\n****\r\n****\r\n";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 3. Циклы: 9":
                    task.Content = "Правый треугольник.\r\nДана сигнатура метода: public void rightTriangle (int x);\r\nНеобходимо реализовать метод таким образом, чтобы он выводил на\r\nэкран треугольник из символов ‘*’ у которого х символов в высоту, а\r\nколичество символов в ряду совпадает с номером строки, при этом\r\nтреугольник выровнен по правому краю. Подсказка: перед символами\r\n‘*’ следует выводить необходимое количество пробелов.\r\n\r\nПример 1:\r\nx=3\r\nрезультат:\r\n  *\r\n **\r\n***\r\n\r\nПример 2:\r\nx=4\r\nрезультат:\r\n   *\r\n  **\r\n ***\r\n****";
                    ValueText("x =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 4. Массивы: 1":
                    task.Content = "Поиск первого значения.\r\nДана сигнатура метода: public int findFirst (int[] arr, int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nиндекс первого вхождения числа x в массив arr. Если число не\r\nвходит в массив – возвращается -1.\r\n\r\nПример:\r\narr=[1,2,3,4,2,2,5]\r\nx=2\r\nрезультат: 1";
                    ValueText("arr =", "x =", "");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 4. Массивы: 3":
                    task.Content = "Поиск максимального.\r\nДана сигнатура метода: public int maxAbs (int[] arr); Необходимо\r\nреализовать метод таким образом, чтобы он возвращал наибольшее по\r\nмодулю (то есть без учета знака) значение массива arr.\r\n\r\nПример:\r\narr=[1,-2,-7,4,2,2,5]\r\nрезультат: -7\r\n";
                    ValueText("arr =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 4. Массивы: 5":
                    task.Content = "Добавление массива в массив.\r\nДана сигнатура метода: public int[] add (int[] arr, int[] ins,\r\nint pos); Необходимо реализовать метод таким образом, чтобы он\r\nвозвращал новый массив, который будет содержать все элементы\r\nмассива arr, однако в позицию pos будут вставлены значения массива\r\nins.\r\n\r\nПример:\r\narr=[1,2,3,4,5]\r\nins=[7,8,9]\r\npos=3\r\nрезультат: [1,2,3,7,8,9,4,5]";
                    ValueText("arr =", "ins =", "pos =");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 4. Массивы: 7":
                    task.Content = "Возвратный реверс.\r\nДана сигнатура метода: public int[] reverseBack (int[] arr);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nновый массив, в котором значения массива arr записаны задом наперед.\r\n\r\nПример:\r\narr=[1,2,3,4,5]\r\nрезультат: [5,4,3,2,1]\r\n";
                    ValueText("arr =", "", "");
                    VisibleValue(Visibility.Visible, Visibility.Collapsed, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 1: Задание 4. Массивы: 9":
                    task.Content = "Все вхождения.\r\nДана сигнатура метода: public int[] findAll (int[] arr, int x);\r\nНеобходимо реализовать метод таким образом, чтобы он возвращал\r\nновый массив, в котором записаны индексы всех вхождений числа x\r\nв массив arr.\r\n\r\nПример:\r\narr=[1,2,3,8,2,2,9]\r\nx=2\r\nрезультат: [1,4,5]";
                    ValueText("arr =", "x =", "");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Collapsed);
                    ChangedTask();
                    break;
                case "Lab 2: Задание 9":
                    task.Content = "Разработать класс с тремя вещественными полями. Создать конструктор\r\nкопирования. Разработать метод, приводящий поля к целому типу.\r\nПерегрузить метод ToString() для формирования строки из полей\r\nкласса. Реализовать дочерний класс (его содержание предложить\r\nсамостоятельно и описать в решении: какой содержательный смысл\r\nимеют поля; реализовать конструкторы; предложить и реализовать 2-3\r\nметода). Протестировать все конструкторы и другие методы базового и\r\nдочернего классов.";
                    VisibleValue(Visibility.Collapsed, Visibility.Collapsed, Visibility.Collapsed);
                    sides.Visibility = Visibility.Visible;
                    input.Visibility = Visibility.Collapsed;
                    outputButton.Visibility = Visibility.Collapsed;
                    answer.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        private void ValueText(string v1, string v2, string v3)
        {
            value1.Text = "";
            value2.Text = "";
            value3.Text = "";
            valueText1.Content = v1;
            valueText2.Content = v2;
            valueText3.Content = v3;
        }

        private void VisibleValue(Visibility v1, Visibility v2, Visibility v3)
        {
            value1.Visibility = v1;
            value2.Visibility = v2;
            value3.Visibility = v3;
            valueText1.Visibility = v1;
            valueText2.Visibility = v2;
            valueText3.Visibility = v3;
        }

        private void ChangedTask()
        {
            input.Visibility = Visibility.Visible;
            outputButton.Visibility = Visibility.Visible;
        }

        public string InputIsCorrect(Func<bool> isCorrect, Func<string> resultFunc)
        {
            if (isCorrect())
            {
                return resultFunc();
            }
            else
            {
                return "Ввод не корректен";
            }
        }

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            switch (textTask)
            {
                case "Lab 1: Задание 1. Методы: 1":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToDouble(value1.Text),
                        () => Tasks.fraction(double.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 1. Методы: 3":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToChar(value1.Text),
                        () => Tasks.charToNum(char.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 1. Методы: 5":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.is2Digits(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 1. Методы: 7":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.isInRange(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Lab 1: Задание 1. Методы: 9":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.isEqual(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Lab 1: Задание 2. Условия: 1":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.abs(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 2. Условия: 3":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.is35(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 2. Условия: 5":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text) && Tasks.IsStringToInt(value3.Text),
                        () => Tasks.max3(int.Parse(value1.Text), int.Parse(value2.Text), int.Parse(value3.Text)).ToString());
                    break;
                case "Lab 1: Задание 2. Условия: 7":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.sum2(int.Parse(value1.Text), int.Parse(value2.Text)).ToString());
                    break;
                case "Lab 1: Задание 2. Условия: 9":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToInt(value1.Text),
                        () => Tasks.day(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 3. Циклы: 1":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.listNums(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 3. Циклы: 3":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.chet(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 3. Циклы: 5":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToLong(value1.Text),
                        () => Tasks.numLen(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 3. Циклы: 7":
                    answer.Content = "Ответ:\n" + InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.square(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 3. Циклы: 9":
                    answer.Content = "Ответ:\n" + InputIsCorrect(
                        () => Tasks.IsStringToPositiveInt(value1.Text),
                        () => Tasks.rightTriangle(int.Parse(value1.Text)).ToString());
                    break;
                case "Lab 1: Задание 4. Массивы: 1":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.findFirst(Tasks.StringToIntArr(value1.Text.Split(' ')), int.Parse(value2.Text)).ToString());
                    break;
                case "Lab 1: Задание 4. Массивы: 3":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')),
                        () => Tasks.maxAbs(Tasks.StringToIntArr(value1.Text.Split(' '))).ToString());
                    break;
                case "Lab 1: Задание 4. Массивы: 5":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToIntArray(value2.Text.Split(' ')) && Tasks.IndexNotOutside(value1.Text.Split(' '), value3.Text),
                        () => Tasks.IntArrToString(Tasks.add(Tasks.StringToIntArr(value1.Text.Split(' ')), Tasks.StringToIntArr(value2.Text.Split(' ')), int.Parse(value3.Text))));
                    break;
                case "Lab 1: Задание 4. Массивы: 7":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')),
                        () => Tasks.IntArrToString(Tasks.reverseBack(Tasks.StringToIntArr(value1.Text.Split(' ')))));
                    break;
                case "Lab 1: Задание 4. Массивы: 9":
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToIntArray(value1.Text.Split(' ')) && Tasks.IsStringToInt(value2.Text),
                        () => Tasks.IntArrToString(Tasks.findAll(Tasks.StringToIntArr(value1.Text.Split(' ')), int.Parse(value2.Text))));
                    break;
                case "Lab 2: Задание 9":
                    sidesInt.Visibility = Visibility.Collapsed;
                    answer.Content = "Ответ: " + InputIsCorrect(
                        () => Tasks.IsStringToDouble(value1.Text) && Tasks.IsStringToDouble(value2.Text) && Tasks.IsStringToDouble(value3.Text),
                        () => ForNumbers());
                    KoLLlmyak straws = new KoLLlmyak(double.Parse(value1.Text), double.Parse(value2.Text), double.Parse(value3.Text));
                    if (Tasks.IsStringToDouble(value1.Text) && Tasks.IsStringToDouble(value2.Text) && Tasks.IsStringToDouble(value3.Text) &&
                        !straws.IsNotTriangle())
                        sidesInt.Visibility = Visibility.Visible;
                    break;
            }
        }

        private string ForNumbers()
        {
            KoLLlmyak straws = new KoLLlmyak(double.Parse(value1.Text), double.Parse(value2.Text), double.Parse(value3.Text));
            return straws.ToString() + "\n" + straws.Triangle();
        }

        private string ForRandomNumbers()
        {
            KoLLlmyak straws = new KoLLlmyak();
            return straws.ToString() + "\n" + straws.Triangle();
        }

        private string ForIntNumbers()
        {
            KoLLlmyak straws = new KoLLlmyak(double.Parse(value1.Text), double.Parse(value2.Text), double.Parse(value3.Text));
            straws.ToInt();
            return straws.ToString() + "\n" + straws.Triangle();
        }

        private void sidesInt_Click(object sender, RoutedEventArgs e)
        {
            answer.Content = ForIntNumbers();
        }

        private void sides_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string s = sides.SelectedItem.ToString().Substring(38);
            answer.Content = "Ответ:";
            answer.Visibility = Visibility.Collapsed;
            input.Visibility = Visibility.Collapsed;
            outputButton.Visibility = Visibility.Collapsed;
            sidesInt.Visibility = Visibility.Collapsed;
            changeSides.Visibility = Visibility.Collapsed;
            switch (s)
            {
                case "Треугольник с рандомными сторонами":
                    VisibleValue(Visibility.Collapsed, Visibility.Collapsed, Visibility.Collapsed);
                    answer.Visibility = Visibility.Visible;
                    changeSides.Visibility = Visibility.Visible;
                    answer.Content = ForRandomNumbers();
                    break;
                case "Треугольник с заданными сторонами":
                    ValueText("x =", "y =", "z =");
                    VisibleValue(Visibility.Visible, Visibility.Visible, Visibility.Visible);
                    ChangedTask();
                    answer.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void changeSides_Click(object sender, RoutedEventArgs e)
        {
            answer.Content = ForRandomNumbers();
        }
    }
}
