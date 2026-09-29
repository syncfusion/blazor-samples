function getTradeData(dataCount) {
        var check = [true, false];
        var Employees = [
            'Michael', 'Kathryn', 'Tamer', 'Martin', 'Davolio', 'Nancy', 'Fuller', 'Leverling', 'Peacock',
            'Margaret', 'Buchanan', 'Janet', 'Andrew', 'Callahan', 'Laura', 'Dodsworth', 'Anne',
            'Bergs', 'Vinet', 'Anton', 'Fleet', 'Zachery', 'Van', 'King', 'Jack', 'Rose'
        ];
        var Designation = ['Manager', 'CFO', 'Designer', 'Developer', 'Program Directory', 'System Analyst', 'Project Lead'];
        var Mail = ['sample.com', 'arpy.com', 'rpy.com', 'mail.com', 'jourrapide.com'];
        var category = ['Energy', 'Financial', 'Technology', 'Industrial'];
        var Location = ['UK', 'USA', 'Sweden', 'France', 'Canada', 'Argentina', 'Austria', 'Germany', 'Mexico'];
        var Status = ['Active', 'InActive'];
        var Trustworthiness = ['Perfect', 'Sufficient', 'InSufficient'];
        var tradeData = [];
        var Address = ["59 rue de l'Abbaye", "Luisenstr. 48", "Rua do Paço, 67", "2, rue du Commerce", "Boulevard Tirou, 255",
            "Rua do Paço, 67", "Hauptstr. 31", "Starenweg 5", "Rua do Mercado, 12", "Carrera 22 con Ave. Carlos Soublette #8-35", "Kirchgasse 6",
            "Sierras de Granada 9993", "Mehrheimerstr. 369", "Rua da Panificadora, 12", "2817 Milton Dr.", "Kirchgasse 6", "Åkergatan 24", "24, place Kléber",
            "Torikatu 38", "Berliner Platz 43", "5ª Ave. Los Palos Grandes", "1029 - 12th Ave. S.",
            "Torikatu 38", "P.O. Box 555", "2817 Milton Dr.", "Taucherstraße 10", "59 rue de l'Abbaye", "Via Ludovico il Moro 22",
            "Avda. Azteca 123", "Heerstr. 22", "Berguvsvägen  8", "Magazinweg 7", "Berguvsvägen  8", "Gran Vía, 1", "Gran Vía, 1",
            "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Magazinweg 7", "Taucherstraße 10", "Taucherstraße 10",
            "Av. Copacabana, 267", "Strada Provinciale 124", "Fauntleroy Circus", "Av. dos Lusíadas, 23",
            "Rua da Panificadora, 12", "Av. Inês de Castro, 414", "Avda. Azteca 123", "2817 Milton Dr."];
        var EmployeeImg = ['usermale', 'userfemale'];
        if (typeof dataCount === 'string') {
            dataCount = parseInt(dataCount);
        }
        for (var i = 1; i <= dataCount; i++) {
            var code = 10000;
            tradeData.push({
                'check': check[Math.floor(Math.random() * check.length)],
                'EmployeeID': code + i,
                'Employees': Employees[Math.floor(Math.random() * Employees.length)] + ' ' + Employees[Math.floor(Math.random() * Employees.length)],
                'Designation': Designation[Math.floor(Math.random() * Designation.length)],
                'Location': Location[Math.floor(Math.random() * Location.length)],
                'Status': Status[Math.floor(Math.random() * Status.length)],
                'Trustworthiness': Trustworthiness[Math.floor(Math.random() * Trustworthiness.length)],
                'Rating': Math.floor(Math.random() * 5),
                'Software': Math.floor(Math.random() * 100),
                'EmployeeImg': EmployeeImg[Math.floor(Math.random() * EmployeeImg.length)],
                'CurrentSalary': Math.floor((Math.random() * 100000)),
                'Address': Address[Math.floor(Math.random() * Address.length)],
            });
            var emp = tradeData[i - 1]["Employees"];
            var sName = emp.substr(0, emp.indexOf(' ')).toLowerCase();
            tradeData[i - 1]['Mail'] = sName + (Math.floor(Math.random() * 100) + 10) + '@@' + Mail[Math.floor(Math.random() * Mail.length)];
        }
        return tradeData;
    }
var virtualData = [], date1 = null, date2 = null, flag = true;
var names = ['hardire', 'abramjo01', 'aubucch01', 'Hook', 'Rumpelstiltskin', 'Belle', 'Emma', 'Regina', 'Aurora', 'Elsa',
    'Anna', 'Snow White', 'Prince Charming', 'Cora', 'Zelena', 'August', 'Mulan', 'Graham', 'Discord', 'Will', 'Robin Hood',
    'Jiminy Cricket', 'Henry', 'Neal', 'Red', 'Aaran', 'Aaren', 'Aarez', 'Aarman', 'Aaron', 'Aaron-James', 'Aarron', 'Aaryan', 'Aaryn',
    'Aayan', 'Aazaan', 'Abaan', 'Abbas', 'Abdallah', 'Abdalroof', 'Abdihakim', 'Abdirahman', 'Abdisalam', 'Abdul', 'Abdul-Aziz',
    'Abdulbasir', 'Abdulkadir', 'Abdulkarem', 'Abdulkhader', 'Abdullah', 'Abdul-Majeed', 'Abdulmalik', 'Abdul-Rehman', 'Abdur',
    'Abdurraheem', 'Abdur-Rahman', 'Abdur-Rehmaan', 'Abel', 'Abhinav', 'Abhisumant', 'Abid', 'Abir', 'Abraham', 'Abu', 'Abubakar',
    'Ace', 'Adain', 'Adam', 'Adam-James', 'Addison', 'Addisson', 'Adegbola', 'Adegbolahan', 'Aden', 'Adenn', 'Adie', 'Adil', 'Aditya',
    'Adnan', 'Adrian', 'Adrien', 'Aedan', 'Aedin', 'Aedyn', 'Aeron', 'Afonso', 'Ahmad', 'Ahmed', 'Ahmed-Aziz', 'Ahoua', 'Ahtasham',
    'Aiadan', 'Aidan', 'Aiden', 'Aiden-Jack', 'Aiden-Vee'];
function dataSource() {
    for (var i = 0; i < 100000; i++) {
        virtualData.push({
            'Field1': names[Math.floor(Math.random() * names.length)],
            'Field2': 1967 + (i % 10),
            'Field3': Math.floor(Math.random() * 200),
            'Field4': Math.floor(Math.random() * 100),
            'Field5': Math.floor(Math.random() * 2000),
            'Field6': Math.floor(Math.random() * 1000),
            'Field7': Math.floor(Math.random() * 100),
            'Field8': Math.floor(Math.random() * 10),
            'Field9': Math.floor(Math.random() * 10),
            'Field10': Math.floor(Math.random() * 100),
            'Field11': Math.floor(Math.random() * 100),
            'Field12': Math.floor(Math.random() * 1000),
            'Field13': Math.floor(Math.random() * 10),
            'Field14': Math.floor(Math.random() * 10),
            'Field15': Math.floor(Math.random() * 1000),
            'Field16': Math.floor(Math.random() * 200),
            'Field17': Math.floor(Math.random() * 300),
            'Field18': Math.floor(Math.random() * 400),
            'Field19': Math.floor(Math.random() * 500),
            'Field20': Math.floor(Math.random() * 700),
            'Field21': Math.floor(Math.random() * 800),
            'Field22': Math.floor(Math.random() * 1000),
            'Field23': Math.floor(Math.random() * 2000),
            'Field24': Math.floor(Math.random() * 150),
            'Field25': Math.floor(Math.random() * 1000),
            'Field26': Math.floor(Math.random() * 100),
            'Field27': Math.floor(Math.random() * 400),
            'Field28': Math.floor(Math.random() * 600),
            'Field29': Math.floor(Math.random() * 500),
            'Field30': Math.floor(Math.random() * 300),
        });
    }
}