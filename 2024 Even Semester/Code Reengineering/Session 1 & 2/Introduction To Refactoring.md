# Introduction To Refactoring
Code Reengineering | Session 1-2

## Refactoring
Refactoring adalah proses merestrukturisasi kode untuk membuatnya lebih mudah dipahami tanpa mengubah fungsi aslinya.

## Manfaat Refactoring
- Membuat kode lebih mudah untuk dipahami
- Membuat kode lebih mudah untuk dimaintenance
- Membuat kode lebih mudah ditambahkan fitur baru
- Membuat kode lebih efisien

## Kapan melakukan Refactoring?
Refactoring dilakukan saat menambahkan fitur baru, memperbaiki bug atau saat melakukan review kode.

## Technical Debt
Menunjukkan akumulasi masalah dalam desain perangkat lunak yang dapat meningkatkan biaya dan kesulitan pengembangan di masa depan.

## Bad Code Smell
Merupakan potensi masalah dalam kode yang dapat diperbaiki dengan refactoring. Contoh :
- The Bloater (Merupakan permasalahan seperti kode yang terlalu besar/panjang)
- Object Oriented Abusers (Merupakan permasalah penggunaan OOP, contohnya seperti penggunaan inheritance yang tidak tepat atau penggunaan switch statement yang terkesan rumit)
- Change Preventer (Situasi dimana perubahan yang terjadi dalam kode memerlukan perubahan pada banyak kode lainnya, menghambat kita untuk mengubah/memperbaikinya)
- Dispensables (Kode yang tidak diperlukan lagi, seperti duplikasi kode, kelas yang tidak efektif dll)
- Couplers (Terlalu banyak ketergantungan antar kelas yang dapat menyulitkan perubahan)