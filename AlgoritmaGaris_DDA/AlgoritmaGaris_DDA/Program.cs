using AlgoritmaGaris_DDA.Object;


float vStep, x_inc, y_inc;

List<Kordinat> ListKordinat = new List<Kordinat>();

float x0 = 0;
float y0 = 0;

float x1 = 0;
float y1 = 0;

Console.WriteLine("Algoritma Garis DDA");
Console.WriteLine("* Tentukan dua titik akhir garis yang akan digambar: (x0, y0) dan (x1, y1)");
Console.WriteLine("Titik Awal");
Console.Write("X0: ");
x0 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y0: ");
y0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Titik Akhir");
Console.Write("X1: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

var dX = x1 - x0;
var dY = y1 - y0;
Console.WriteLine("* Hitung selisih koordinat x dan y antara kedua titik: dx = x1 - x0 dan dy = y1 - y0.");
Console.WriteLine($@"|dX| = X1 - X0 => {x1} - {x0} = {x1 - x0}");
Console.WriteLine($@"|dY| = Y1 - Y0 => {y1} - {y0} = {y1 - y0}");
Console.WriteLine($@"* Tentukan jumlah langkah yang diperlukan untuk menggambar garis");
Console.WriteLine($@"yang dapat diambil sebagai nilai maksimum antara |dx| dan |dy|");

if (dX > dY)
{
    Console.WriteLine($@"* Dapat kita lihat nilai |dX| > |dY| maka jumlah langkah = {dX}");
}
else {
    Console.WriteLine($@"* Dapat kita lihat nilai |dX| < |dY| maka jumlah langkah = {dY}");
}

vStep = dX > dY ? dX : dY;

#region x_inc & y_inc
x_inc = dX / vStep;
y_inc = dY / vStep;
#endregion

Console.WriteLine($@"* Hitung perubahan dalam x dan y untuk setiap langkah: x_inc = dx / jumlah_langkah dan y_inc = dy / jumlah_langkah.");
Console.WriteLine($@"x_inc = dX / jumlah langkah => {dX}/{vStep} = {dX / vStep}");
Console.WriteLine($@"y_inc = dY / jumlah langkah => {dY}/{vStep} = {dY / vStep}");
Console.WriteLine($@"* Lakukan pengulangan dengan menambah nilai |X| + jumlah langkah dan nilai |Y| + jumlah langkah hingga nilai |X| > X1");

#region Iteration
Console.WriteLine($@"* Tentukan titik awal untuk menggambar garis, (x, y), yang sama dengan titik awal ({x0}, {y0})");
ListKordinat.Add(new Kordinat() { 
    x = x0,
    y = y0
});

var x_iteration = x0;

var y_iteration = y0;

int iteration = 1;

while (x_iteration < x1)
{
    Console.WriteLine($@"Iteration {iteration++}");
    Console.WriteLine($@"X => {x_iteration} + {x_inc} = {Math.Round(x_iteration + x_inc)}");
    Console.WriteLine($@"Y => {y_iteration} + {y_inc} = {Math.Round(y_iteration + y_inc)}");
    x_iteration += x_inc;
    y_iteration += y_inc;
    ListKordinat.Add(new Kordinat()
    {
        x = x_iteration,
        y = y_iteration
    });
}
Console.WriteLine($@"Setelah perhitungan selesai,");
Console.WriteLine($@"didapat hasil sebagai berikut : ");
Console.WriteLine(String.Join(",", ListKordinat.Select(d => (d.x, d.y)).ToArray()));

#endregion



