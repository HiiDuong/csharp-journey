// ===== KHÚC 1: BẢNG GIÁ =====
// Ghi giá vào đây một lần, sau này dùng tên thay cho số
const decimal GIA_MAY_THUONG = 8000m;
const decimal GIA_MAY_VIP = 12000m;
const decimal GIA_MI = 15000m;
const decimal GIA_STING = 16000m;
const decimal TI_LE_GIAM = 0.05m;

// ===== KHÚC 2: HỎI LOẠI MÁY =====
Console.Write("Loai may (1 = thuong, 2 = VIP): ");
string? inputMay = Console.ReadLine();

decimal giaMoiGio;
if (inputMay == "1")
{
    giaMoiGio = GIA_MAY_THUONG;
}
else if (inputMay == "2")
{
    giaMoiGio = GIA_MAY_VIP;
}
else
{
    Console.WriteLine("Loi: chi duoc nhap 1 hoac 2!");
    return;
}

// ===== KHÚC 3: HỎI SỐ GIỜ =====

Console.Write("Nhap so gio choi: ");
string? inputGio = Console.ReadLine();

if (!decimal.TryParse(inputGio, out decimal soGio) || soGio <= 0)
{
    Console.WriteLine("Loi: so gio phai la so duong!");
    return;
}


// ===== KHÚC 4: HỎI SỐ MÌ =====
Console.Write("Nhap so luong mi: ");
string? inputMi = Console.ReadLine();

if (!int.TryParse(inputMi, out int soMi) || soMi < 0)
{
    Console.WriteLine("Loi: so mi khong duoc nho hon 0");
    return;
}

// ===== KHÚC 5: HỎI SỐ STING =====
Console.Write("Nhap so luong sting: ");
string? inputSting = Console.ReadLine();

if (!int.TryParse(inputSting, out int soSting) || soSting < 0)
{
    Console.WriteLine("Loi: so sting khong duoc nho hon 0");
    return;
}

// ===== KHÚC 6: HỎI CHIẾN BINH =====
Console.Write("La thanh vien Chien Binh? (y/n): ");
string? inputThanhVien = Console.ReadLine();
bool laChienBinh = inputThanhVien == "Y";

// ===== KHÚC 7: TÍNH TIỀN =====
decimal tienGio = giaMoiGio * soGio;

decimal tienGiam = 0m;
if (laChienBinh)
{
    tienGiam = tienGio * TI_LE_GIAM;
}

decimal tienDoAn = (soMi * GIA_MI) + (soSting * GIA_STING);

decimal tongTien = tienGio - tienGiam + tienDoAn;

// ===== KHÚC 8: IN HÓA ĐƠN =====
Console.WriteLine("===== HOA DON =====");
Console.WriteLine($"Tien gio choi : {tienGio:N0}");
Console.WriteLine($"Tien giam     : {tienGiam:N0}");
Console.WriteLine($"Tien do an    : {tienDoAn:N0}");
Console.WriteLine($"TONG PHAI TRA : {tongTien:N0}");
