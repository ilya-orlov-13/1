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
