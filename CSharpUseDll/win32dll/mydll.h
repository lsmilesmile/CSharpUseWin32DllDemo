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


/// �����෽����C#�������Բ�������
class MyClass {
public:
	MyClass(void) {};
	~MyClass(void) {};
	int CAdd(int num1, int num2);
};
/// ����MyClss����
EXPORTC MyClass* STDCALL GetClsObj();
EXPORTC int STDCALL TestCAdd(MyClass* myCls, int num1, int num2);


/// ��������ͨ����
EXPORTC int STDCALL Add(int num1, int num2);
/// ��������ͨ������ָ��
EXPORTC double STDCALL AddPtr(double* num1, double* num2);
/// ������char*
EXPORTC char* STDCALL TestParamChar(char* s);
/// ���ò���
EXPORTC void STDCALL TestParamQuote(int& p);
/// ����������
EXPORTC void STDCALL TestParamArray(const int arr[], const int n, int& sum);
/// �������飬C++����ֱ�Ӵ������飬ֻ�ܴ�������ָ��
EXPORTC void STDCALL TestOutArr(const int n, const int arr[], int* arr2);
/// �����ַ�����
EXPORTC void STDCALL TestCharArr(char t[]);
/// �����ǽṹ��
typedef struct StuInfo
{
	char name[64];
	int age;
};
EXPORTC void STDCALL TestStruct(StuInfo stu);
/// �����ǽṹ��ָ��
EXPORTC void STDCALL TestStructPtr(StuInfo* stu);
/// ������Ƕ�׵Ľṹ��
typedef struct CountStuInfo
{
	int count;
	StuInfo stuinfo[100];
};
EXPORTC void STDCALL TestStruct2(CountStuInfo* cst);

/// dll����opencvͼ���c#
EXPORTC void STDCALL CSharpGetOpencvPicFromDll_Way1(unsigned char* data, size_t& size);
EXPORTC unsigned char* STDCALL CSharpGetOpencvPicFromDll_Way2(int& width, int& height, int& step); // ����˳���ȡͼ��ߴ�


