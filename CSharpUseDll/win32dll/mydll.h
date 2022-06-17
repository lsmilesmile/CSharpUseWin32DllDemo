#pragma once

#ifdef _MSC_VER
#define STDCALL		__stdcall
#elif defined(__GNUC__)
#if defined(__ppc__) || defined(__ppc64__)
#define STDCALL 
#else
#define STDCALL __attribute__((stdcall))
#endif
#else 
#define STDCALL 
#endif

#ifndef DLL_EXPORT
#define DLL_EXPORT __declspec(dllexport)
#endif
#ifndef EXPORTC
#define EXPORTC extern "C" DLL_EXPORT
#endif


/// 导出类方法给C#，并测试参数传递
class MyClass {
public:
	MyClass(void) {};
	~MyClass(void) {};
	int CAdd(int num1, int num2);
};
/// 创建MyClss对象
EXPORTC MyClass* STDCALL GetClsObj();
EXPORTC int STDCALL TestCAdd(MyClass* myCls, int num1, int num2);


/// 参数是普通变量
EXPORTC int STDCALL Add(int num1, int num2);
/// 参数是普通变量的指针
EXPORTC double STDCALL AddPtr(double* num1, double* num2);
/// 参数是char*
EXPORTC char* STDCALL TestParamChar(char* s);
/// 引用参数
EXPORTC void STDCALL TestParamQuote(int& p);
/// 参数有数组
EXPORTC void STDCALL TestParamArray(const int arr[], const int n, int& sum);
/// 传出数组，C++不能直接传出数组，只能传出数组指针
EXPORTC void STDCALL TestOutArr(const int n, const int arr[], int* arr2);
/// 传出字符数组
EXPORTC void STDCALL TestCharArr(char t[]);
/// 参数是结构体
typedef struct StuInfo
{
	char name[64];
	int age;
};
EXPORTC void STDCALL TestStruct(StuInfo stu);
/// 参数是结构体指针
EXPORTC void STDCALL TestStructPtr(StuInfo* stu);
/// 参数是嵌套的结构体
typedef struct CountStuInfo
{
	int count;
	StuInfo stuinfo[100];
};
EXPORTC void STDCALL TestStruct2(CountStuInfo* cst);

/// dll传递opencv图像给c#
EXPORTC void STDCALL CSharpGetOpencvPicFromDll_Way1(unsigned char* data, size_t& size);
EXPORTC unsigned char* STDCALL CSharpGetOpencvPicFromDll_Way2(int& width, int& height, int& step); // 可以顺便获取图像尺寸


