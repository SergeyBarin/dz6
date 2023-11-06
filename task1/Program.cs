int Prompt(string message) {
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] InputArray(int lenght) {
    int[] array = new int [lenght];
    for(int i = 0; i < array.Length; i++) {
        array[i] = Prompt($"Введите {i + 1}-й элемент");
    }
    return array;
}
void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"а [{i}] = {array[i]}");
    }
}
int CountPositiveNumbers(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0){
            count++;
        }
    }
    return count;
}
int Length = Prompt("Введите количество элементов >");
int[] array;
array = InputArray(Length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");
