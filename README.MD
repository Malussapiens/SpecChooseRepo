# Итоговое задание первого блока курса "Разработчик" 

**Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

---
Содержание проекта:
- код программы находится в папке SpecChoose/Program
- блок-схема алгоритма находится в файле Algorythm.drawio

### Алгоритм программы (словесное описание)
*Предполагается, что массив строк задан заранее и процедура вывода содержимого массива также имеется.* 

1. Принимаем массив строк strings[];
2. Создаем пустой массив строк result[];
3. Пока не конец strings[] цикл(i=0, j=0):
4. Если длина string[i] меньше 4, то: 
5. Увеличиваем размер result[] на 1;
6. result[j]=string[i];
7. j++;
8. Конец цикла;
9. Выводим содержимое result[];

