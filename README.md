# Final-control-work
## Задача  для  выполнения проверочной работы:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).
## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [].

## Описания алгоритма:
### Вариант_001
Определяем массив_1 и кладем в него 5 элементов( разной длины)
Определяем массив_2 и кладем в него масcив_1 со всеми элементами.
Создоем метод MekArray который принимает два аргумета (массив_1 и массив_2)
Проходим цклом for по всему массиву_1 проверяя условия что элементы массива_1 <=3, если Да тогда  массив_1 с элементом [i] кладем в массив_2 с элементом [count] ,а  count увеличиваем на 1 и возврощаемся к циклу  for в котором i тоже увеличивается на 1. И так проверяем весь массив.После выводим на экран только массив_2 с отсогртнрованными элементами которые <=3.
### Вариант_002

## Схема описания программы для трех вариантов находятся в папке Scheme.

## Решение алгоритма находится по пути Final-control-work/variant_001/002/003.
