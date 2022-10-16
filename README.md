# *Привет*, ниже приведён алгоритм решения задачи :
## Текст задачи: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
### Ход решения:
* Объявляю 2 массива с типом String (**Первоначальный массив** ввожу с клавиатуры), **второй массив** нам понадобится для присвоения элементам массива строк, длина которых меньше либо равна 3 символа
* Объявляю метод **SortingArray**(передаю методу тип и параметры используемые в массиве), задача метода по очереди перебрать все элементы **Первоначального массива**. В теле массива объявляется условие, при котором в случае если строка <= 3 символа, строка приваивается элементу второго массива
* Объявляю метод **PrintSortingArray**, задача метода вывод на экран сформированного **второго массива**, состоящего из строк <= 3 символа
* Вызываю метод **SortingArray**, передаю методу параметры Первоначального массива, второго массива
* Вызываю метод **PrintSortingArray**, передаю методу параметры второго массива

## Задача решена, + блок схема в папке Scheme