1.1
Дробная часть. 
Дана сигнатура метода: public double fraction (double x); 
Необходимо реализовать метод таким образом, чтобы он возвращал только 
дробную часть числа х. Подсказка: вещественное число может быть 
преобразовано к целому путем отбрасывания дробной части. 
Пример: 
x=5,25 
результат: 0,25

```
   public double fraction(double x)
        {
            //отбрасывание дробной части
            int a = (int)x;
            //дробная часть
            double b = x - a;
            return b;
        }
```

<img width="255" height="43" alt="1 1 1" src="https://github.com/user-attachments/assets/826e3f90-a9dd-4b21-8b65-541357da9e2b" />
<img width="250" height="37" alt="1 1 2" src="https://github.com/user-attachments/assets/9c06a87b-007d-49b1-a5f8-f4f9034a716f" />



1.3
Букву в число.  
Дана сигнатура метода: public int charToNum (char x); 
Метод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7 
8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал 
символ в соответствующее число. Подсказка: код символа ‘0’ — это число 48. 
 
Пример: 
x=’3’ 
результат: 3 

```
   public int charToNum(char x)
        {
            int c = x - '0';
            return c;
        }
```

<img width="138" height="36" alt="1 3 1" src="https://github.com/user-attachments/assets/cfeee71f-d837-4bef-a2a0-caea9bb312a1" />
<img width="154" height="42" alt="1 3 2" src="https://github.com/user-attachments/assets/435188c2-7060-42c3-ab83-378be8320659" />
<img width="143" height="37" alt="1 3 3" src="https://github.com/user-attachments/assets/21bf080e-9ca3-4b86-bae5-7a5aa7f55f0c" />




1.5
Двузначное.  
Дана сигнатура метода: public bool is2Digits (int x); 
Необходимо реализовать метод таким образом, чтобы он принимал число x и 
возвращал true, если оно двузначное.  
 
Пример 1: 
x=32 
результат: true 
 
Пример 2: 
x=516 
результат: false

```
   public bool is2Digits(int x)
        {
            int c = 0;
            //количество цифр
            while (x != 0)
            {
                x /= 10;
                c++;
            }
            if (c == 2) return true;
            else return false;
        }
```

<img width="154" height="35" alt="1 5 1" src="https://github.com/user-attachments/assets/77573e9d-2ec7-42fe-8bd5-8b0c236409e5" />
<img width="153" height="40" alt="1 5 2" src="https://github.com/user-attachments/assets/1d6faa09-475c-4b41-8f80-a9fefedea475" />
<img width="156" height="46" alt="1 5 3" src="https://github.com/user-attachments/assets/d2cd1521-30a9-4772-946f-4336c6b468e9" />



1.7
Диапазон.  
Дана сигнатура метода: public bool isInRange (int a, int b, int num); 
Метод принимает левую и правую границу (a и b) некоторого числового 
диапазона. Необходимо реализовать метод таким образом, чтобы он возвращал 
true, если num входит в указанный диапазон (включая границы). Обратите 
внимание, что отношение a и b заранее неизвестно (неясно кто из них больше, а 
кто меньше) 
 
Пример 1: 
a=5 b=1 num=3 
результат: true 
 
Пример 2: 
a=2 b=15 num=33 
результат: false 

```
   public bool isInRange(int a, int b, int num)
        {
            if (a < b)
            {
                if (a <= num && num <= b) return true;
                else return false;
            }
            else
            {
                if (b <= num && num <= a) return true;
                else return false;
            }
        }
```

<img width="161" height="120" alt="1 7 1" src="https://github.com/user-attachments/assets/524bd4d4-32f5-4d68-af3d-2f84df9ab742" />
<img width="170" height="87" alt="1 7 2" src="https://github.com/user-attachments/assets/79fe14ba-9e11-47f2-9dd6-0c686166d506" />



1.9
Равенство.  
Дана сигнатура метода: public bool isEqual(int a, int b, int c); 
Необходимо реализовать метод таким образом, чтобы он возвращал true, если 
все три полученных методом числа равны 
 
Пример 1: 
a=3 b=3 с=3 
результат: true 
 
Пример 2: 
a=2 b=15 с=2 
результат: false 


```
   public bool isEqual(int a, int b, int c)
        {
            if (a == b && a == c) return true;
            else return false;
        }
```

<img width="162" height="84" alt="1 9 1" src="https://github.com/user-attachments/assets/06ab1daf-398c-46fa-a9c2-3925311ccfb3" />
<img width="143" height="88" alt="1 9 2" src="https://github.com/user-attachments/assets/d1b9726a-8058-4b79-81a5-f4dd55b82361" />
<img width="151" height="151" alt="1 9 3" src="https://github.com/user-attachments/assets/2d6862a4-0ef4-4808-a0a4-914488a92e2f" />



2.1
Модуль числа.  
Дана сигнатура метода: public int abs (int x); 
Необходимо реализовать метод таким образом, чтобы он возвращал модуль 
числа х (если оно было положительным, то таким и остается, если он было 
отрицательным – то необходимо вернуть его без знака минус). 
 
Пример 1: 
x=5 
результат: 5 
 
Пример 2: 
x=-3 
результат: 3 

```
   public int abs(int x)
        {
            if (x > 0) return x;
            else return x * -1;
        }

```
<img width="134" height="89" alt="2 1 1" src="https://github.com/user-attachments/assets/0831996f-5b2b-4d39-917d-dbd10774fc34" />
<img width="127" height="56" alt="2 1 2" src="https://github.com/user-attachments/assets/196280cb-9d87-41df-a332-3804194026e4" />



2.3
Тридцать пять.  
Дана сигнатура метода: public bool is35 (int x); 
Необходимо реализовать метод таким образом, чтобы он возвращал true, если 
число x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то 
вернуть надо false. Подсказка: оператор % позволяет получить остаток от 
деления. 
 
Пример 1: 
x=5 
результат: true 
 
Пример 2: 
x=8  
результат: false 
 
Пример 3: 
x=15 
результат: false 

```
   public bool is35(int x)
        {
            if (x % 3 == 0 && x % 5 == 0) return false;
            if (x % 3 == 0 || x % 5 == 0) return true;
            else return false;
        }
```

<img width="122" height="56" alt="2 3 1" src="https://github.com/user-attachments/assets/36a3e9dd-c721-4aae-a8e4-835ce2bcc98e" />
<img width="133" height="56" alt="2 3 2" src="https://github.com/user-attachments/assets/ec0f8474-4a2b-4b8c-9679-2f37093d9bb7" />



2.5
Тройной максимум.  
Дана сигнатура метода: public int max3 (int x, int y, int z); 
Необходимо реализовать метод таким образом, чтобы он возвращал 
максимальное из трех полученных методом чисел. Подсказка: идеальное 
решение включает всего две инструкции if и не содержит вложенных if. 
 
Пример 1: 
x=5  y=7  z=7 
результат: 7 
 
Пример 2: 
x=8  y=-1  z=4 
результат: 8 

```
   public int max3(int x, int y, int z)
        {
            if (x >= y && x >= z) return x;
            if (y >= x && y >= z) return y;
            else return z;
        }
```

