using System.Collections.Generic;

namespace Course_paper
{
    class BinarySearch
    {
        static string[] names_array;
        public static char[] Wanted_char_array { get; set; }

        static bool IsWantedValue(int index)//данный метод осуществляет проверку на то что текущее слово соответсвтует тому что нужно найти
        {
            for (int i = 0; i < Wanted_char_array.Length; i++)
                if (names_array[index].ToCharArray().Length - 1 >= i)
                    if (Wanted_char_array[i] != names_array[index].ToCharArray()[i])
                    return false;
            return true;
        }

        static int BinarySearchCore()//
        {
            int left = 0, right = names_array.Length - 1;
            while (left <= right) //пока не сошлись границы массива
            {
                bool is_left_border = false, is_right_border = false;
                int middle = left + (right - left) / 2; //индекс среднего элемента

                if (right - left == 1)
                {
                    if (IsWantedValue(left)) return left;
                    if (IsWantedValue(right)) return right;
                    return -1;
                }
                
                if (IsWantedValue(middle)) return middle;
                else for (int i = 0; i < Wanted_char_array.Length; i++)
                        if (names_array[middle].ToCharArray().Length - 1 >= i)
                            if ((Wanted_char_array[i] != names_array[middle].ToCharArray()[i]))
                            if ((Wanted_char_array[i] < names_array[middle].ToCharArray()[i]))
                            {
                                if (is_left_border != true) is_right_border = true;
                            }
                            else if (is_right_border != true) is_left_border = true;

                //Для корректной работы имена должны быть с большой буквы!!!

                if (!is_left_border && is_right_border) right = middle; //сужаем рабочую зону массива с правой стороны
                if (!is_right_border && is_left_border) left = middle; //сужаем рабочую зону массива с левой стороны
            }
            return -1; //ничего не нашли
        }//

        public static int SearchContact(List<ContactDatabase> data)//Данный метод был создан для заполнения списка именами из БД
        {
            names_array = new string[data.Count];
            for (int i = 0; i <= data.Count - 1; i++) names_array[i] = data[i].Name;

            return BinarySearchCore();
        }
    }
}