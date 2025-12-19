## Introduction

Impact of Singleton / Transient dependency in a medium to large application

## Setup
1. Generated a bunch of services (approx 1000 services)
2. Registered them to DI using a custom Extension method (Register)
3. In the Register method:
    -> Change the AddScoped to AddTransient and vice versa to see the performance difference

## How to run
1. Run migrations first
    -> dotnet ef database update
2. Use dotnet run to run the application

## UI
1. Run a seed using `Seed` button if you want to check against data
2. Change the value in the text box and click on `Run Tests`
    > This sends N number of parallel requests to the server
3. Inspect the timing of your requests using network tab

## Result

### AddScoped (100 parallel requests)
<img width="1183" height="658" alt="image" src="https://github.com/user-attachments/assets/21990342-b894-4761-b705-ecc5955af589" />

### AddTransient (10 parallel requests) -- other requests failed due to OOM

<img width="1194" height="364" alt="image" src="https://github.com/user-attachments/assets/2e9f0bc3-542f-4c45-ae79-0e60cd78e6b1" />



