# Aşı Uygulaması Veritabanı Tasarımı ve Senaryolar

## 1. Tablolar ve Alanlar

### Görevliler (Staff)
- **StaffID** (int, Primary Key): Görevli ID'si.
- **Name** (nvarchar(100)): Görevli adı.
- **Username** (nvarchar(50)): Görevli kullanıcı adı.
- **Password** (nvarchar(100)): Görevli şifresi (hashlenmiş).
- **Role** (nvarchar(50)): Görevli rolü ("Admin" veya "Normal").

### Hastalar (Patients)
- **PatientID** (int, Primary Key): Hasta ID'si.
- **Name** (nvarchar(100)): Hasta adı.
- **Surname** (nvarchar(100)): Hasta soyadı.
- **DateOfBirth** (date): Doğum tarihi.
- **Gender** (nvarchar(10)): Cinsiyet.
- **PhoneNumber** (nvarchar(20)): Telefon numarası.

### Aşılar (Vaccines)
- **VaccineID** (int, Primary Key): Aşı ID'si.
- **VaccineName** (nvarchar(100)): Aşı adı.
- **Description** (nvarchar(255)): Aşı açıklaması.
- **CreatedBy** (int, Foreign Key -> Staff.StaffID): Ekleyen görevli.

### Randevular (Appointments)
- **AppointmentID** (int, Primary Key): Randevu ID'si.
- **PatientID** (int, Foreign Key -> Patients.PatientID): Hasta ID'si.
- **VaccineID** (int, Foreign Key -> Vaccines.VaccineID): Aşı ID'si.
- **AppointmentDate** (datetime): Randevu tarihi ve saati.
- **Status** (nvarchar(50)): Randevu durumu ("Planned", "Completed").

### Aşı Kayıtları (VaccinationRecords)
- **RecordID** (int, Primary Key): Aşı kayıt ID'si.
- **PatientID** (int, Foreign Key -> Patients.PatientID): Hasta ID'si.
- **VaccineID** (int, Foreign Key -> Vaccines.VaccineID): Aşı ID'si.
- **VaccinationDate** (datetime): Aşı tarihi.
- **AdministeredBy** (int, Foreign Key -> Staff.StaffID): Aşıyı uygulayan görevli.

---

## 2. Tablolar Arasındaki İlişkiler

1. **Görevliler ile Aşılar**:
   - Görevli, yeni bir aşı ekler (**CreatedBy**).

2. **Hastalar ile Randevular**:
   - Hasta, randevu alır.

3. **Randevular ile Aşılar**:
   - Randevu, belirli bir aşıya atanır.

4. **Hastalar ile Aşı Kayıtları**:
   - Hasta, aşı olduğunda kaydedilir.

5. **Aşı Kayıtları ile Görevliler**:
   - Aşı, bir görevli tarafından uygulanır.

---

## 3. Senaryolar ve Uygulama Adımları

### 3.1. Giriş Formu
- Görevli, kullanıcı adı ve şifre ile sisteme giriş yapar.
- Görevlinin rolüne göre yetkiler atanır.

### 3.2. Hasta Yönetimi
- Hasta ekleme, düzenleme ve silme işlemleri yapılır.

### 3.3. Randevu Yönetimi
- Hasta için randevu oluşturulur.
- Randevu tarih ve saatine göre planlama yapılır.

### 3.4. Aşı Yönetimi
- Admin, yeni aşılar ekler.
- Dropdown menüsünde aşılar listelenir.

### 3.5. Aşı Kayıtları
- Hasta aşı olduktan sonra, bu bilgi kaydedilir.
- Aşı kayıtları listelenir.

### 3.6. DatagridView Filtreleme
- Yaş gruplarına göre hastalar filtrelenir ve sıralanır.




# çalıştırılacak kod
```
USE AsiUygulamasi;

CREATE TABLE Staff (
    StaffID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Surname NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10),
    PhoneNumber NVARCHAR(20)
);

CREATE TABLE Vaccines (
    VaccineID INT PRIMARY KEY IDENTITY(1,1),
    VaccineName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    CreatedBy INT FOREIGN KEY REFERENCES Staff(StaffID)
);

CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    VaccineID INT FOREIGN KEY REFERENCES Vaccines(VaccineID),
    AppointmentDate DATETIME NOT NULL,
    Status NVARCHAR(50) NOT NULL
);

CREATE TABLE VaccinationRecords (
    RecordID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT FOREIGN KEY REFERENCES Patients(PatientID),
    VaccineID INT FOREIGN KEY REFERENCES Vaccines(VaccineID),
    VaccinationDate DATETIME NOT NULL,
    AdministeredBy INT FOREIGN KEY REFERENCES Staff(StaffID)
);






INSERT INTO Staff (Name, Username, Password, Role)
VALUES ('kübraa', 'k', '12345', 'Admin');
```
