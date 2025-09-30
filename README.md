## Задание 1. Методы

### Задача 1.1 - Дробная часть
**Условие:** Реализовать метод, который возвращает только дробную часть числа x.

```csharp
public double fraction(double x)
{
    decimal decimalX = (decimal)x;
    decimal integerPart = Math.Truncate(decimalX);
    decimal fractionalPart = decimalX - integerPart;
    return (double)fractionalPart;
}
```

**Алгоритм:**
1. Преобразовать double в decimal для точности вычислений
2. Выделить целую часть с помощью Math.Truncate()
3. Вычислить дробную часть как разность исходного числа и целой части
4. Вернуть дробную часть как double

<img width="255" height="43" alt="1 1 1" src="https://github.com/user-attachments/assets/826e3f90-a9dd-4b21-8b65-541357da9e2b" />
<img width="250" height="37" alt="1 1 2" src="https://github.com/user-attachments/assets/9c06a87b-007d-49b1-a5f8-f4f9034a716f" />


### Задача 1.3 - Букву в число
**Условие:** Преобразовать символ, представляющий цифру, в соответствующее число.

```csharp
public int charToNum(char x)
{
    int c = x - '0';
    return c;
}
```

**Алгоритм:**
1. Использовать вычитание кодов символов
2. '0' имеет код 48 в ASCII, поэтому вычитание дает числовое значение
3. Вернуть полученное число

<img width="138" height="36" alt="1 3 1" src="https://github.com/user-attachments/assets/cfeee71f-d837-4bef-a2a0-caea9bb312a1" />
<img width="154" height="42" alt="1 3 2" src="https://github.com/user-attachments/assets/435188c2-7060-42c3-ab83-378be8320659" />
<img width="143" height="37" alt="1 3 3" src="https://github.com/user-attachments/assets/21bf080e-9ca3-4b86-bae5-7a5aa7f55f0c" />


### Задача 1.5 - Двузначное
**Условие:** Проверить, является ли число двузначным.

```csharp
public bool is2Digits(int x)
{
    int c = 0;
    while (x != 0)
    {
        x /= 10;
        c++;
    }
    return c == 2;
}
```

**Алгоритм:**
1. Инициализировать счетчик цифр
2. Делить число на 10 пока оно не станет 0, увеличивая счетчик
3. Вернуть true если счетчик равен 2

<img width="154" height="35" alt="1 5 1" src="https://github.com/user-attachments/assets/77573e9d-2ec7-42fe-8bd5-8b0c236409e5" />
<img width="153" height="40" alt="1 5 2" src="https://github.com/user-attachments/assets/1d6faa09-475c-4b41-8f80-a9fefedea475" />
<img width="156" height="46" alt="1 5 3" src="https://github.com/user-attachments/assets/d2cd1521-30a9-4772-946f-4336c6b468e9" />


### Задача 1.7 - Диапазон
**Условие:** Проверить, входит ли число в диапазон (неизвестно какой границей является a, а какой b).

```csharp
public bool isInRange(int a, int b, int num)
{
    if (a < b)
    {
        return a <= num && num <= b;
    }
    else
    {
        return b <= num && num <= a;
    }
}
```

**Алгоритм:**
1. Определить минимальную и максимальную границу диапазона
2. Проверить принадлежность числа к диапазону [min, max]
3. Вернуть результат проверки

<img width="161" height="120" alt="1 7 1" src="https://github.com/user-attachments/assets/524bd4d4-32f5-4d68-af3d-2f84df9ab742" />
<img width="170" height="87" alt="1 7 2" src="https://github.com/user-attachments/assets/79fe14ba-9e11-47f2-9dd6-0c686166d506" />


### Задача 1.9 - Равенство
**Условие:** Проверить, равны ли все три числа.

```csharp
public bool isEqual(int a, int b, int c)
{
    return a == b && a == c;
}
```

**Алгоритм:**
1. Сравнить первое число со вторым
2. Сравнить первое число с третьим
3. Вернуть true только если все три числа равны

<img width="162" height="84" alt="1 9 1" src="https://github.com/user-attachments/assets/06ab1daf-398c-46fa-a9c2-3925311ccfb3" />
<img width="143" height="88" alt="1 9 2" src="https://github.com/user-attachments/assets/d1b9726a-8058-4b79-81a5-f4dd55b82361" />
<img width="151" height="151" alt="1 9 3" src="https://github.com/user-attachments/assets/2d6862a4-0ef4-4808-a0a4-914488a92e2f" />


## Задание 2. Условия

### Задача 2.1 - Модуль числа
**Условие:** Вернуть модуль числа x.

```csharp
public int abs(int x)
{
    if (x > 0) 
        return x;
    else 
        return x * -1;
}
```

**Алгоритм:**
1. Проверить знак числа
2. Если положительное - вернуть как есть
3. Если отрицательное - умножить на -1

<img width="134" height="89" alt="2 1 1" src="https://github.com/user-attachments/assets/0831996f-5b2b-4d39-917d-dbd10774fc34" />
<img width="127" height="56" alt="2 1 2" src="https://github.com/user-attachments/assets/196280cb-9d87-41df-a332-3804194026e4" />


### Задача 2.3 - Тридцать пять
**Условие:** Проверить делимость на 3 или 5, но не на оба одновременно.

```csharp
public bool is35(int x)
{ 
    if (x % 3 == 0 && x % 5 == 0) 
        return false;
    if (x % 3 == 0 || x % 5 == 0) 
        return true;
    else 
        return false;
}
```

**Алгоритм:**
1. Проверить делимость на 3 И на 5 - вернуть false
2. Проверить делимость на 3 ИЛИ на 5 - вернуть true
3. Иначе вернуть false

<img width="122" height="56" alt="2 3 1" src="https://github.com/user-attachments/assets/36a3e9dd-c721-4aae-a8e4-835ce2bcc98e" />
<img width="133" height="56" alt="2 3 2" src="https://github.com/user-attachments/assets/ec0f8474-4a2b-4b8c-9679-2f37093d9bb7" />


### Задача 2.5 - Тройной максимум
**Условие:** Найти максимальное из трех чисел.

```csharp
public int max3(int x, int y, int z)
{
    if (x >= y && x >= z) 
        return x;
    if (y >= x && y >= z) 
        return y;
    else 
        return z;
}
```

**Алгоритм:**
1. Сравнить x с y и z
2. Если x максимальное - вернуть x
3. Сравнить y с x и z
4. Если y максимальное - вернуть y
5. Иначе вернуть z

### Задача 2.7 - Двойная сумма
**Условие:** Вернуть сумму чисел, но если сумма в диапазоне 10-19, вернуть 20.

```csharp
public int sum2(int x, int y)
{
    int sum = x + y;
    if (sum >= 10 && sum <= 19) 
        return 20;
    else 
        return sum;
}
```

**Алгоритм:**
1. Вычислить сумму x + y
2. Проверить попадание суммы в диапазон [10, 19]
3. Если попадает - вернуть 20
4. Иначе вернуть фактическую сумму

### Задача 2.9 - День недели
**Условие:** Преобразовать число в день недели.

```csharp
public String day(int x)
{
    switch (x)
    {
        case 1: return "Понедельник";
        case 2: return "Вторник";
        case 3: return "Среда";
        case 4: return "Четверг";
        case 5: return "Пятница";
        case 6: return "Суббота";
        case 7: return "Воскресенье";
        default: return "это не день недели";
    }
}
```

**Алгоритм:**
1. Использовать switch для преобразования чисел 1-7
2. Для каждого случая вернуть соответствующее название дня
3. Для невалидных чисел вернуть сообщение об ошибке

## Задание 3. Циклы

### Задача 3.1 - Числа подряд
**Условие:** Вернуть строку с числами от 0 до x.

```csharp
public String listNums(int x)
{
    string s = "";
    for (int i = 0; i <= x; i++)
    {
        s += i + " ";
    }
    return s;
}
```

**Алгоритм:**
1. Инициализировать пустую строку
2. В цикле от 0 до x добавлять числа и пробелы
3. Вернуть результирующую строку

### Задача 3.3 - Четные числа
**Условие:** Вернуть строку с четными числами от 0 до x.

```csharp
public String chet(int x)
{
    string s = "";
    for (int i = 0; i <= x; i += 2)
    {
        s += i + " ";
    }
    return s;
}
```

**Алгоритм:**
1. Инициализировать пустую строку
2. В цикле с шагом 2 добавлять четные числа
3. Вернуть результирующую строку

### Задача 3.5 - Длина числа
**Условие:** Вернуть количество цифр в числе.

```csharp
public int numLen(long x)
{
    int c = 0;
    while (x != 0)
    {
        x /= 10;
        c++;
    }
    return c;
}
```

**Алгоритм:**
1. Инициализировать счетчик
2. Делить число на 10 пока не станет 0, увеличивая счетчик
3. Вернуть количество итераций

### Задача 3.7 - Квадрат
**Условие:** Вывести квадрат из символов размером x×x.

```csharp
public void square(int x)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}
```

**Алгоритм:**
1. Внешний цикл для строк
2. Внутренний цикл для столбцов
3. Выводить "* " в каждой позиции
4. Переходить на новую строку после каждой строки

### Задача 3.9 - Правый треугольник
**Условие:** Вывести треугольник, выровненный по правому краю.

```csharp
public void rightTriangle(int x)
{
    for (int i = 1; i <= x; i++)
    {
        for (int j = 0; j < x - i; j++)
        {
            Console.Write(' ');
        }
        for (int j = 0; j < i; j++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}
```

**Алгоритм:**
1. Внешний цикл для строк
2. Первый внутренний цикл для пробелов (выравнивание вправо)
3. Второй внутренний цикл для звездочек
4. Количество звездочек равно номеру строки

## Задание 4. Массивы

### Задача 4.1 - Поиск первого значения
**Условие:** Найти индекс первого вхождения числа в массиве.

```csharp
public int findFirst(int[] arr, int x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            return i;
        }
    }
    return -1;
}
```

**Алгоритм:**
1. Пройти по массиву от начала до конца
2. Сравнить каждый элемент с искомым значением
3. При нахождении вернуть индекс
4. Если не найдено - вернуть -1

### Задача 4.3 - Поиск максимального по модулю
**Условие:** Найти элемент с наибольшим абсолютным значением.

```csharp
public int maxAbs(int[] arr)
{
    if (arr == null || arr.Length == 0)
    {
        throw new ArgumentException("Массив пустой");
    }

    int maxAbsValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (Math.Abs(arr[i]) > Math.Abs(maxAbsValue))
        {
            maxAbsValue = arr[i];
        }
    }
    return maxAbsValue;
}
```

**Алгоритм:**
1. Проверить что массив не пустой
2. Взять первый элемент как начальный максимум
3. Пройти по остальным элементам
4. Сравнивать абсолютные значения
5. Вернуть элемент с максимальным модулем

### Задача 4.5 - Добавление массива в массив
**Условие:** Вставить один массив в другой на указанную позицию.

```csharp
public int[] add(int[] arr, int[] ins, int pos)
{
    if (pos < 0 || pos > arr.Length)
    {
        throw new ArgumentOutOfRangeException("Позиция должна быть в диапазоне от 0 до " + arr.Length);
    }

    int[] result = new int[arr.Length + ins.Length];

    for (int i = 0; i < pos; i++)
    {
        result[i] = arr[i];
    }

    for (int i = 0; i < ins.Length; i++)
    {
        result[pos + i] = ins[i];
    }

    for (int i = pos; i < arr.Length; i++)
    {
        result[ins.Length + i] = arr[i];
    }

    return result;
}
```

**Алгоритм:**
1. Проверить корректность позиции
2. Создать новый массив суммарного размера
3. Скопировать элементы до позиции вставки
4. Вставить элементы второго массива
5. Скопировать оставшиеся элементы первого массива

### Задача 4.7 - Возвратный реверс
**Условие:** Вернуть новый массив с элементами в обратном порядке.

```csharp
public int[] reverseBack(int[] arr)
{
    if (arr == null)
    {
        throw new ArgumentNullException("Массив пустой");
    }

    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - 1 - i];
    }
    return result;
}
```

**Алгоритм:**
1. Проверить что массив не null
2. Создать новый массив того же размера
3. Заполнить его элементами в обратном порядке
4. Вернуть новый массив

### Задача 4.9 - Все вхождения
**Условие:** Вернуть массив индексов всех вхождений числа.

```csharp
public int[] findAll(int[] arr, int x)
{
    if (arr == null)
    {
        throw new ArgumentNullException("Массив пустой");
    }

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            count++;
        }
    }

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            result[index] = i;
            index++;
        }
    }
    return result;
}
```

**Алгоритм:**
1. Проверить что массив не null
2. Первым проходом посчитать количество вхождений
3. Создать массив нужного размера
4. Вторым проходом заполнить массив индексами
5. Вернуть массив индексов







