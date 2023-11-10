#include <iostream>
#include<queue>
#include<vector>
#include<ctime>
#include<string>
#include<stack>
using namespace std;

void PrintVector(vector<int>a)
{
    for (int i = 0; i < a.size(); i++)
    {
        cout << a[i] << "\t";
    }
    cout << endl;
}

vector<int> Merge(vector<int> list1, vector<int> list2)
{
    int l1 = 0;
    int l2 = 0;
    vector<int>tmp;
    while (l1 < list1.size() && l2 < list2.size())
    {
        if (list1[l1] <= list2[l2])
        {
            tmp.push_back(list1[l1]);
            l1++;
        }
        else
        {
            tmp.push_back(list2[l2]);
            l2++;
        }
    }
    while (l1 < list1.size())
    {
        tmp.push_back(list1[l1]);
        l1++;
    }
    while (l2 < list2.size())
    {
        tmp.push_back(list2[l2]);
        l2++;
    }
    //cout << "Серия массива:" << endl;
    //cout << "| "; PrintVector(tmp);
    //cout << "|" << endl;
    return tmp;
}

void MergeSort(vector<int>& list)
{
    if (list.size() < 2)
    {
        return;
    }
    vector<int> left;
    vector<int> right;
    int mid = list.size() / 2;
    for (int i = 0; i < mid; i++)
    {
        left.push_back(list[i]);
    }
    for (int i = mid; i < list.size(); i++)
    {
        right.push_back(list[i]);
    }
    MergeSort(left);
    MergeSort(right);
    list = Merge(left, right);
}

//Естественное слияние................
//void PrintSeries(vector<vector<int>>arr)
//{
//    for (int i = 0; i < arr.size(); i++)
//    {
//        cout << i + 1 << "-я серия: ";
//        cout << "| ";
//        for (int j = 0; j < arr[i].size(); j++)
//        {
//            cout << arr[i][j] << " ";
//        }
//        cout << "|" << endl;
//    }
//}

vector<vector<int>> SplitToSeries(vector<int>Arr)
{
    vector<vector<int>>Mattrix;
    int i = 0;
    while (i < Arr.size())
    {
        vector<int>NewSerie;
        NewSerie.push_back(Arr[i]);
        i++;

        while (i < Arr.size() && Arr[i - 1] <= Arr[i])
        {
            NewSerie.push_back(Arr[i]);
            i++;
        }
        Mattrix.push_back(NewSerie);
    }
    //cout << "Ваши серии:" << endl;
    //PrintSeries(Mattrix);
    return Mattrix;
}

vector<int> NaturalMerge(vector<int> list)
{
    vector<vector<int>> mat = SplitToSeries(list);
    while (mat.size() >= 2)
    {
        vector<int> Merged = Merge(mat[0], mat[1]);
        mat.push_back(Merged);
        mat.erase(mat.begin());
        mat.erase(mat.begin());
    }
    return mat[0];
}

void InterpolationSearch(int key, vector<int>A)
{
    int left = 0;
    int right = A.size() - 1;
    int mid;
    bool flag = false;

    while (A[left] <= key && A[right] >= key && flag !=true)
    {
        mid = left + ((key - A[left]) * (right - left)) / (A[right] - A[left]);

        if (A[mid] == key) flag = true;
        if (A[mid] > key) right = mid - 1;
        else left = mid + 1;
    }


    if (flag)
        cout << "Yes eleme" << endl << "index:  " << mid << endl;
    else
        cout << "No elem" << endl;
}

void FindSubstrInStr(string str, string substr)
{
    int strsize = str.length();
    int substrsize = substr.length();
    int res = -1;

    for (int i = 0; i < strsize - substrsize + 1; i++)
    {
        for (int j = 0; j < substrsize; j++)
        {
            if (substr[j] != str[i + j])
                break;
            else 
                if (j == substrsize - 1)
                {
                    res = i;
                    break;
                }
        }
    }
    if (res == -1)
        cout << "No elem" << endl;
    else
        cout << "Yes eleme" << endl << "index:  " << res << endl;
}

void LineSearch(vector<int>v, int key)
{
    int res = -1;
    for (int i = 0; i < v.size(); i++)
    {
        if (v[i] == key)
        {
            res = i;
        }
    }

    if (res == -1)
        cout << "No elem" << endl;
    else
        cout << "Yes eleme" << endl << "index:  " << res << endl;

}

void BinarySearch(vector<int>v, int key)
{
    bool flag = false;
    int left = 0;
    int size = v.size();
    int right = size-1;
    int mid;


    while ((left <= right) && (flag != true))
    {
        mid = (left + right) / 2;

        if (v[mid] == key) flag = true;
        if (v[mid] > key) right = mid - 1;

        else left = mid+1;
    }


    if (flag)
        cout << "Yes eleme" << endl << "index:  " << mid << endl;
    else
        cout << "No elem" << endl;
}

int BMSearch(string str, string substr)
{
    int strsize = str.length();
    int subsize = substr.length();
    int res = -1;

    int i, pos;
    int doparr[256];

    for (int i = 0; i < 256; i++)
        doparr[i] = subsize;

    for (i = subsize - 2; i >= 0; i--)
    {
        if (doparr[int((unsigned char)substr[i])] == subsize)
        {
            doparr[int((unsigned char)substr[i])] = subsize - i - 1;
        }
    }

    pos = subsize - 1;
    while (pos < strsize)
    {
        if (substr[subsize - 1] != str[pos])
            pos += doparr[int((unsigned char)str[pos])];
        else
        {
            for (i = subsize - 1; i >= 0; i--)
            {
                if (substr[i]!=str[pos-subsize+i+1])
                { 
                     pos+= doparr[int((unsigned char)str[pos - subsize + i + 1])];
                     break;
                }
                else if (i == 0)
                {
                    return pos - subsize + 1;
                }
            }
        }
    }
    return res;
}

int KMPSearch(string str, string substr)
{
    vector<int>prefix(substr.length());
    prefix[0] = 0;
    int i = 1; int j = 0;
    

    while (i < substr.length())
    {
        if (substr[i] != substr[j])
        {
            if (j==0) 
            {
                prefix[i] = 0;
                i++;
            }
            else
            {
                j = prefix[j - 1];
            }
        }
        else
        {
            prefix[i] = j + 1;
            i++;
            j++;
        }
    }

    for (int g = 0; g < prefix.size(); g++)
    {
        cout << prefix[g] << "  ";
    }

    int k = 0, l = 0;
    while (k < str.length())
    {
        if (substr[l] == str[k])
        {
            k++;
            l++;
            if (l == substr.length()) 
                return k / 8;
        }
        else
        {
            if (l == 0)
            {
                k++;
            }
            else l = prefix[l - 1];
        }
    }
    return -1;
}

void shell(vector<int>& array, int size)
{
    int temp1, j;
    for (int step = size / 2; step > 0; step /= 2)
    {
        for (int i = step; i < size; i++)
        {
            temp1 = array[i];

            for (j = i; j >= step; j -= step)
            {
                if (temp1 < array[j - step])
                {
                    array[j] = array[j - step];
                }
                else break;
            }
            array[j] = temp1;
        }

    }
}

void huara(vector<int>&items, int left, int right)
{
    int i = left, j = right;
    double tmp, mid = items[(left + right) / 2];

    do {
        while (items[i] < mid)
            i++;
        while (items[j] > mid)
            j--;

        if (i <= j)
        {
            if (i < j)
            {
                tmp = items[i];
                items[i] = items[j];
                items[j] = tmp;
            }
            i++;
            j--;
        }
    } while (i <= j);

    if (i < right)
        huara(items, i, right);
    if (left < j)
        huara(items, left, j);
}

int main()
{
    setlocale(LC_ALL, "rus");
    srand(time(NULL));
    vector<int>vec = { 25,4,7,10,5 };
    huara(vec, 0, vec.size() - 1);
    PrintVector(vec);

    LineSearch(vec, 4);
    PrintVector(vec);

    InterpolationSearch(7, vec);
    BinarySearch(vec, 25);
    string substr = "abbaabbab";
    string str = "substring";
    FindSubstrInStr(str, substr);

    int tmp = BMSearch(str, substr);
    cout << tmp << endl;
    
    int k = KMPSearch(str, substr);
    if (k == -1)
        cout << "netu" << endl;
    else
        cout << "est'" << endl;
    //shell(vec, vec.size());
    PrintVector(vec); 
}