#include <iostream>
using namespace std;
/*
int chen(int a[], int n)
{
	int i, j, x;
	for (i = 1; i < n; i++)
	{
		x = a[i];
		j = i - 1;   //di chuyển các phần tử có giá trị lớn hơn giá trị x về sau một vị trí so với vị trí ban đầu của nó 
		while (j>=0&&a[j]>x)
		{
			a[j + 1] = a[j];//tăng j 1 vị trí
			j = j - 1;//giảm số j
		}
		a[j + 1] = x;//nếu a[j]<x
	}
	return -1;
}
int inarray(int a[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout <<" "<<a[i];
	}
	return 0;
}
int main()
{
	int a[8];
	int n=sizeof(a)/sizeof(a[0]);
	for (int i = 0; i < n; i++)
	{
		cout << "nhap vao mang: ";
		cin >> a[i];
	}
	cout << "\n mang truoc khi sap xep la: ";
	inarray(a,n);
	chen(a,n);
	cout << "\n mang sau khi sap xep la: ";
	inarray(a,n);
	return 0;
}*/
/*void swap(int& a, int& b) {
	int t = a;
	a = b;
	b = t;
}

int selection(int a[], int n)
{
	int i, j, Min_index;
	// Di chuyển ranh giới của mảng đã sắp xếp và chưa sắp xếp
	for (i = 0; i < n - 1; i++) {
		//Tìm phần tử nhỏ nhất trong mảng chưa sắp xếp
		Min_index = i;
		for (j = i + 1; j < n; j++) {
			if (a[j] < a[Min_index])
				Min_index = j;
		}
		int t = a[Min_index];
		a[Min_index] = a[i];
		a[i] = t;
		swap(a[Min_index], a[i]);
	}
	return -1;
}
int InArray(int a[], int n)
{
	for (int i = 0; i < n; i++)
		cout << " " << a[i];
	return 0;
}
int main()
{
	int a[5];
	int n = sizeof(a) / sizeof(a[0]);
	for (int i = 0; i < n; i++) 
	{
		cout << "Nhap so vao mang: ";
		cin >> a[i];
	}
	cout << "\nMang chua sap xep la: ";
	InArray(a, n);
	cout << "\nMang sap xep la: ";
	selection(a, n);
	InArray(a, n);
	return 0;
}*/
int noibot(int a[], int n)
{
	int i, j;
	
	for (i = 0; i < n - 1; i++)//i phần tử cuối cùng đã được sắp xếp
	{
		for (j = 0; j < n - i - 1; j++)
		{
			if (a[j] > a[j + 1])
				/* {
					int t = a[j];
					a[j] = a[j + 1];
					a[j + 1] = t;
				}*/
				swap(a[j], a[j + 1]);
		}
	}
	return -1;
}
int InArray(int a[], int n)
{
	for (int i = 0; i < n; i++)
		cout << " " << a[i];
	return 0;
}
int main() {
	int a[6];
	int n = sizeof(a) / sizeof(a[0]);
	for (int i = 0; i < n; i++)
	{
		cout << "\n Nhap so vao mang: ";
		cin >> a[i];
	}
	cout << "\nMang truoc khi sap xep: ";
	InArray(a, n);
	cout << "\nMang sau khi sap xep: ";
	noibot(a, n);
	InArray(a, n);
	return 0;
}