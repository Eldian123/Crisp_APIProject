### Test Case: 01 (Happy Path)
Title: Get Patient with ID 111
Test Description: Searching data using ID
Test data: Id = 111
Expected Data: [{"Id":"111","Name":"Jenn D.","DateOfBirth":"1934-06-01","Address":"CA"}]
Actual Data: [{"Id":"111","Name":"Jenn D.","DateOfBirth":"1934-06-01","Address":"CA"}]

### Test Case: 02 (Happy Path)
Title: Get Patient with Name Jack
Test Description: Searching data using Name
Test data: Name = Jack
Expected Data: [{"Id":"222","Name":"Jack","DateOfBirth":"1956-05-01","Address":"MD"}]
Actual Data: [{"Id":"222","Name":"Jack","DateOfBirth":"1956-05-01","Address":"MD"}]

### Test Case: 03 (Happy Path)
Title: Get Patient with Address MD
Test Description: Searching data using Address
Test data: Address = MD
Expected Data: [{"Id":"222","Name":"Jack","DateOfBirth":"1956-05-01","Address":"MD"}]
Actual Data: [{"Id":"222","Name":"Jack","DateOfBirth":"1956-05-01","Address":"MD"}]

### Test Case: 04 (Unhappy Path)
Title: Get Patient with Address Empty
Test Description: Searching data using Address
Test data: Address = ""
Expected Data: []
Actual Data: []

### Test Case: 05 (Unhappy Path)
Title: Get Patient with Invalid ID
Test Description: Searching data using ID
Test data: Id = *12
Expected Data: []
Actual Data: []

### Test Case: 06 (Unhappy Path)
Title: Get Patient with Invalid DateOfBirth format
Test Description: Searching data using DateOfBirth
Test data: DateOfBirth = 1934/06/01
Expected Data: []
Actual Data: []


### This is imaginary Bug/Defect
Title: Get Patient with Invalid DateOfBirth format
Bug Description: Searching data using DateOfBirth
Test data: DateOfBirth = 1934/06/01
Expected Data: []
Actual Data: [{"Id":"111","Name":"Jenn D.","DateOfBirth":"1934-06-01","Address":"CA"}]


 
