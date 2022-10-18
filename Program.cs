Console.Write("Введите 3 чила через разделитель ';' : ");
String Temp_numbers = Console.ReadLine();
float temp=0;
int length = Temp_numbers.Length;
int pozition_1 =Temp_numbers.IndexOf(';');
int pozition_2 =Temp_numbers.IndexOf(';',pozition_1+1);
var arr = new float[]{0,0,0}; //инициализация массива из 3х хначений
string Numbers_1_str_tmp = Temp_numbers.Substring(0, pozition_1);
string Numbers_2_str_tmp = Temp_numbers.Substring(pozition_1+1,pozition_2-pozition_1-1);
string Numbers_3_str_tmp = Temp_numbers.Substring(pozition_2+1,length-pozition_2-1);
arr[0] = float.Parse(Numbers_1_str_tmp);
arr[1] = float.Parse(Numbers_2_str_tmp);
arr[2] = float.Parse(Numbers_3_str_tmp);

for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
Console.Write("max = ");
Console.WriteLine(arr[2]);
//не организованы проверки как и в задании 2, жестко зашито 3 числа, нет проверки на 2 максимальных
