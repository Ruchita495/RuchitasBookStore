﻿=============================================================================================================================
													PART-1
=============================================================================================================================													
﻿2023-10-24 0313
Add readme file

2023-10-24 0314
create github repo

2023-10-24 0318
options => options.SignIn.RequireConfirmedAccount = true cut the cod from startup.cs file and past it for reference

2023-10-24 0320
start to learn part1 and change the startup.cs file

2023-10-24 0328
start and learn part 1.1 and undertands the files

2023-10-24 0333
startd part 1.2 bootstrap

2023-10-27 0150
continue working on the assignment-2
text the app 
and it run successfully

2023-10-27 0156
replace the existing bootstrap.css file found in wwwroot > lib > dist > css
and add new bootstrap file which is download from bootswatch.com

2023-10-27 0200
change the file name bootstrap.min.css to bootstrap.css in view > shared > _Layout.cshtml file
use Morph theam

2023-10-27 0205
change the nav class in _Layout.cshtml file

add additional property to footer class - text-white-50 bg-primary


2023-10-27 0240
add jquery links and scriptes in _Layout.cshtml file

2023-10-27 0252
add dropdown menue in _Layout.cshtml file
2023-10-30 0718


2023-10-30 0755
modify the namespace
delete Class1.cs file from all projects
Buid the project

2023-10-30 0810
Move models folder to RuchitasBooks.Models project


2023-10-30 0818
add project reference
rename Models folder to ViewModels 
change the namespace from namespace RuchitasBookStore.Models to namespace RuchitasBookStore.Models.ViewModels

2023-10-30 0850
add SD.cs file i RuchitasBooks.Utility project

2023-10-31 1235
slove error in Startup.cshtml file
delete one ApplicationDbContext.cs file from RuchitasBookStore project

2023-10-31 1240
add Area-> Customer
add controller 
delete Data and Models folder
add _ViewStart.cshtml and _ViewImport.cshtml files
change the path in _ViewStart.cshtml file
Run the app it run successfully

2023-10-31 1250
add Area-> Admin
add controller 
delete Data and Models folder
add _ViewStart.cshtml and _ViewImport.cshtml files
change the path in _ViewStart.cshtml file
Run the app it run successfully

2023-11-02 1125
Create a new project called RuchitasBooks.DataAccess,  RuchitasBooks.Models and  RuchitasBooks.Utility

=============================================================================================================================
													PART-2
=============================================================================================================================
2023-11-03 1130
start par-2
create database migration
20231105182629_AddCategoryToDb
update database

2023-11-04 0230
build the project
Run the app it run successfully

2023-11-04 0240
add new class file called Category.cs and modify it according to slide

2023-11-04 0244
add migration using - add-migration AddCategoryToDb 

2023-11-05 0128
add migration and update data base in RuchitasBooks.DataAccess project migration folder

2023-11-05 0131
create Repository and IRepository folder in RuchitasBooks.DataAccess project

2023-11-05 0140
add IRepository.cs fille and modify the code

2023-11-05 0145
add additional code in IRepository.cs file

2023-11-05 0150
add Repository.cs file and modify the code 

2023-11-05 0235
add different files and interface file 

2023-11-05 0245
add SP_Call .cs file in Repository folder and modify the code

2023-11-05 0320
update the code in SP_Call.cs file

2023-11-05 0350
update UnitOfWork.cs file and add code in Startup.cs file
services.AddScoped<UnitOfWork, UnitOfWork>();

2023-11-05 0410
create new controller in Area-> Admin-> Controllers and modify the code

2023-11-06 0400
add new Index.cshtml file in Area->Admin->View

2023-11-06 0420
create _CreateAndBackToListButton.cshtml file in Views - >Shared

2023-11-06 0425
create _EditAndBackToListButton.cshtml file in Views - >Shared

2023-11-06 0445
add code in _Upsert.cshtml file

2023-11-06 0530
update the code in files

2023-11-06 0630
build the application
run successfuly 

=============================================================================================================================
													PART-3
=============================================================================================================================
2023-11-17 0815
build the application
run successfuly 

2023-11-17 0930
create migration and add CoverType.cs file and also Create interface ICoverTypeRepository.cs and CoverTypeRepository.cs file

20231120195024_AddCovertypeToDb

2023-11-17 1008
perform CURD operations on CoverType

2023-11-17 1020
create Product.cs file and add the code 
create migration to RuchitasBooks.DataAccess -> Migration folder
20231120195552_AddProductToDb

2023-11-17 1130
build project
run successfully


2023-11-17 1145
create a file in Area -> Admin-> Product -> Upsert.cshtml

2023-11-17 1150
app run successfully

2023-11-17 1205
add sweet alert script in Area->Admin->Product->Upsert.cshtml


=============================================================================================================================
													PART-3
=============================================================================================================================
20213-11-22 0356
write a code in product controller so create product page is diaplayed

2023-11-22 0426
update code in product.cs file and Area->Customer->View->Home->Index.cshtml to diaply images of books in home page

2023-11-22 0438
add some code in productrepository file and create image folder in wwwroot folder to store product images

2023-11-22 0445
write some code in Admin->Customer->Controller->HomeController.cs file

2023-11-22 0513
add code in Area->Admin->View->Product->Upsert.cshtml file to display Price,Price50 and Prices100 textbox

2023-11-23 1107
by mistake i deleted the Product Table from database so i created new migration for Product table
20231123160258_AddProductsToDb

2023-11-23 1125
add code in SD.cs file

2023-11-27 0650
add code in upsert.cshtml file