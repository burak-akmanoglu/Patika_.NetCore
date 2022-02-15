# Merge Sort
* [16,21,11,8,12,22] Dizisinin Merge Sort ile sıralanması.

1. İlk adım olarak diziyi tek eleman kalana kadar diziyi 2'ye bölüyoruz.

* [16,21,11] -- [8,12,22]
* [16]  [21,11] -- [8,12] [22]
* [16] [21] [11] -- [8] [12] [22]

2. Daha sonra sıralayarak adım adım birleştiriyoruz.

* [16] [11,21] -- [8,12] [22]
* [11,16,21] -- [8,12,22]
* [8,11,12,16,21,22]

#### Big-O Gösterimi:
O(nlogn)