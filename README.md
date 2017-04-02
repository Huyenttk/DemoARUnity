# DemoARUnity
List demo about AR Unity from Boku

Bài AR_01: 
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
