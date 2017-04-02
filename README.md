# DemoARUnity
List demo about AR Unity from Boku

Bài 1 AR_01: 

=================================================

Mục tiêu của bài này là tạo 1 project AR Unity nhận dạng bar code thành hình con nhện

1. Tạo Database Vuforial —> Add Vuforia SDK + Add database của Vuforia vào project
2. Vào Vuforia/ Prefabs/ Add AR Camera vào project
 - Inspector của Camera/ 
     + check vào checkbox để display Camera 
     + Position Y = 10.5
     + Rotation Y = 90 
 - Inspector/ Open Vuforial configuration/ 
     + Add App license key
     + Check vào Load ARDemo Database và Active 
3. Vào Vuforia/ Prefabs/ Add Image Target vào project
4. Vào Vuforia/ Prefabs/ Add spider_myOldOne vào Hierarchy/ Image target
5. Tạo jum_animation Controller
6. Vào fantasySpider/ Spider_myOldOne/ Run, kéo  vào Animator
7. Chọn spider_myOldOne/ inspector/
     + kéo spider my_OldOne vào mục Avata
     + kéo jum_AnimationControler vào muc Controller
8. Run và thấy kết kết quả barcode được nhận dạng thành hình con nhện nhảy 

=================================================

Bài 2 AR_02

=================================================

Mục tiêu hôm nay: Tao nút trên màn hình, tao hành vi cho các nút đó

1. Làm các buoc nhu bài AR_01 nhưng mà đối  tượng là con ngựa
2. Add mấy Animation của con ngựa vào màn hình —> Tạo transition
3. Add canvas —> Add button 
    - set vị trí của button, 
    - màu sắc của button (chọn color của phần image), 
    - đặt tên button lại(2 chỗ)
4. Vào asset tao 1 folder đăt tên là script —> trong thu muc script tạo file  C# Script
5. Nhap double vô file C# sau khi tao ra thì sẽ open ra monoDevelop-Unity để viết script trong đó
6. Kéo horseScript vào Inspector của Canvas
7. Chọn Walk/ Inspector/ Onclick() , add Walk cho sự kiện Onclick 
8. Run thử 
9. Đieu chinh chuyen từ run thành walk, sao cho tgian Idle là ít

=================================================
