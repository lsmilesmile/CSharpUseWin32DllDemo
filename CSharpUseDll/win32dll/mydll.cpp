#include "mydll.h"

#include <fstream>
#include <opencv2\opencv.hpp>

#ifdef _DEBUG
#pragma comment(lib, "opencv_world3410d.lib")
#else
#pragma comment(lib, "opencv_world3410.lib")
#endif // _DEBUG


int MyClass::CAdd(int num1, int num2) {
	return num1 + num2;
}

EXPORTC MyClass* STDCALL GetClsObj() {
	MyClass* myCls = new MyClass(); // 这儿的内存应该是不用释放的，c#那边会释放
	return myCls;
}

EXPORTC int STDCALL TestCAdd(MyClass* myCls, int num1, int num2) {
	int res = myCls->CAdd(num1, num2);
	return res;
}

EXPORTC int STDCALL Add(int num1, int num2) {
	return num1 + num2;
}

EXPORTC double STDCALL AddPtr(double* num1, double* num2) {
	return *num1 + *num2;
}

EXPORTC char* STDCALL TestParamChar(char* s) {
	// 接收C# string
	std::ofstream out("char.txt");
	out << "Here is the string from c#: " << s << "\n";
	out.close();
	// 返回给C#的char*
	char* s1 = "This a cpp string";
	return s1; 

	// 如果直接将传进来的s return，c#那边会出错
	// 不会错
	/*s = "12345";
	return s;*/

	// 会错
	/*return s;*/
}

EXPORTC void STDCALL TestParamQuote(int& p) {
	p = p + 10;
}

EXPORTC void STDCALL TestParamArray(const int arr[], const int n, int& sum) {
	sum = 0;
	for (int i = 0; i < n; i++) {
		sum += arr[i];
	}
}

EXPORTC void STDCALL TestOutArr(const int n, const int arr[], int* arr2) {
	for (int i = 0; i < n; i++) {
		arr2[i] = arr[i] + 100;
	}
}

EXPORTC void STDCALL TestCharArr(char t[]) {
	strcpy(t, "lsmile");
}

EXPORTC void STDCALL TestStruct(StuInfo stu) {
	strcpy(stu.name, "felix");
	stu.age = 20;
}

EXPORTC void STDCALL TestStructPtr(StuInfo* stu) {
	strcpy(stu->name, "felix");
	stu->age = 20;
}

EXPORTC void STDCALL TestStruct2(CountStuInfo* cst) {
	cst->count = 10;
	for (int i = 0; i < cst->count; i++) {
		strcpy(cst->stuinfo[i].name, "stu");
		cst->stuinfo[i].age = 20 + i;
	}
}

EXPORTC void STDCALL CSharpGetOpencvPicFromDll_Way1(unsigned char* data, size_t& size) {
	cv::Mat img(cv::Size(500, 500), CV_8UC3, cv::Scalar(0, 255, 0));
	std::vector<unsigned char> buf;
	cv::imencode(".jpg", img, buf); // 该方法在opencv2.4.12的版本中怎么试都不行，buf size 都是0
	size = buf.size();
	for (unsigned char &var : buf)
	{
		*data = var;
		data++;
	}
}

EXPORTC unsigned char* STDCALL CSharpGetOpencvPicFromDll_Way2(int& width, int& height, int& step) {
	cv::Mat tmp(cv::Size(500, 500), CV_8UC3, cv::Scalar(0, 255, 0));
	unsigned char* data = new unsigned char[tmp.size().height*tmp.size().width];
	data = tmp.data;
	width = tmp.size().width;
	height = tmp.size().height;
	step = tmp.step;
	return data;
}
