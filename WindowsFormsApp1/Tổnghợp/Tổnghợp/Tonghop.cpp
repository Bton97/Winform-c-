#include <iostream>
using namespace std;
/*
struct Nhanvien
{
	string MaNV;
	string tenNV;
	string Diachi;
	string phong;
	float Luong;
	int tuoi;
};
int main() {
	Nhanvien nv;
	cout << "Nhap ma nv: ";
	cin>>nv.MaNV;
	cin>>nv.tenNV;
	cin>>nv.Diachi;
	cin>>nv.phong;
	cin>>nv.Luong;
	cin>>nv.tuoi;
	cout << nv.MaNV <<"\n"<<nv.Diachi<<"\n"<<nv.phong<<"\n"<<nv.Luong <<"\n"<<nv.tuoi<<endl;
	return 0;
}*/
/*
struct  hinhchunhat
{
	int dai;
	int rong;
	int chuvi;
	float dientich;
};
int main() {
	hinhchunhat hcn;
	cout << "Nhap vao chieu dai: ";
	cin >> hcn.dai;
	cout << "\nNhap vao chieu rong: ";
	cin >> hcn.rong;
	hcn.chuvi = (hcn.dai + hcn.rong) * 2;
	hcn.dientich = hcn.dai * hcn.rong;
	cout << "\nChu vi hcn la : " << hcn.chuvi;
	cout << "\nDien tich hcn la " << round(hcn.dientich) << endl;
}*/
/*void swap(int* a, int* b)
{
	int temp;
	temp = *a;
	*a = *b;
	*b = temp;
}
int main()
{
	int a,b;
	cout << "Nhap vao so: ";
	cin >> a;
	cin>>b;
	cout << "\nTruoc khi doi: "<<a<<" "<<b;
	swap(&a,&b);
	cout << "\nSau khi doi: " << a << " " <<b<<endl;
}*/
struct PHANSO
{
	int Tu;
	int Mau;
};
void nhapPS(PHANSO &x) {
	cout << "\nNhap tu so: ";
	cin >> x.Tu;
	cout << "\nNhap mau so: ";
	cin >> x.Mau;
}
int UCLN(int a, int b) {
	if(a%b!=0){
		return UCLN(b, a%b);//đệ quy đề tìm
	}
	else
	{
		return b;
	}
}
void inPS(PHANSO x)
{
	int ucln = UCLN(x.Tu, x.Mau);//Dùng tử và mẫu chia cho ước chung lớn nhất
	x.Tu = x.Tu / ucln;
	x.Mau = x.Mau / ucln;
	if (x.Mau != 1) {//nếu mẫu khác 1
		if (x.Mau < 0) {//nếu mẫu bé hơn 0 thì tử mẫu nhân -1 để thành dương
			x.Mau = x.Mau * -1;
			x.Tu = x.Tu * -1;
		}
		cout << x.Tu << "/" << x.Mau;//nếu lớn hơn 0 thì in ra tử mẫu
	}
	else//nếu mẫu = 1 thì chỉ in tử
		cout << x.Tu;
}
PHANSO TichPS(PHANSO n1, PHANSO n2)
{
	PHANSO tps;
	tps.Tu = n1.Tu * n2.Tu;
	tps.Mau = n1.Mau * n2.Mau;
	return tps;
}
int main() 
{
	PHANSO ps1, ps2, ps3;
	nhapPS(ps1);
	nhapPS(ps2);
	cout <<"Phan so thu nhat la: "; inPS(ps1);
	cout << "\nPhan so thu hai la: "; inPS(ps2);
	/*ps3.tu = ps1.tu * ps2.tu;
	ps3.mau = ps1.mau * ps2.mau;*/
	ps3 = TichPS(ps1, ps2);
	cout << "\nTich cua 2 phan so tren la: "; inPS(ps3);
}