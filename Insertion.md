# Insertion Sort

* [22,27,16,2,18,6] dizisini Inseriton Sort ile sıralayalım

1) İlk olarak dizideki en küçük değeri buluyoruz. Bu bizim dizimizde 2'dir.
2) En baştaki değerimiz ile yani 22 ile 2'nin yerlerini değiştiriyoruz. 

* Dizimizin son hali : 
[2,27,16,22,18,6]

3) Daha sonra dizimizin 1. index'ine geçiyoruz. Bu bizim dizimide 27'dir. Daha sonra dizinin sağ tarafında kalan en küçük sayıyı buluyoruz. Bu 6'dır. 6 ile 27'nin yerlerini değiştiriyoruz.
* Dizimizin son hali : 
[2,6,16,22,18,27]
4) İşlemler dizinin sağ tarafındaki en küçük sayı ile yer değiştirerek devam etmektedir.

**İşlem aşamaları:**
Dizinin orjinal hali: [22,27,16,2,18,6]


1. Adım [2,27,16,22,18,6]
2. Adım [2,6,16,22,18,27]
3. Adım [2,6,16,22,18,27] 
4. Adım [2,6,16,18,22,27]
5. Adım [2,6,16,18,22,27]   

**Big-O Gösterimi:** O(n^2)'dir

**Time Complexity:** 
* Average case = O(n^2) 
* Worst case =  O(n^2)
* Best case = O(n)

**18 Sayısı Hangi Time Complexity'dir?**
* Average Case: 18 sonda ya da başta değildir. Bu yüzden Average'dir.

***
**[7,3,5,8,2,9,4,15,6] Dizisinin Inserion Sort'a göre ilk 4 adımı :**
1. Adım: [2,3,5,8,7,9,4,16,6]
2. Adım: [2,3,4,8,7,9,5,16,6]
3. Adım: [2,3,4,5,7,9,8,16,6]
4. Adım: [2,3,4,5,6,9,8,16,7]

