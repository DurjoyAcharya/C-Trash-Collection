#include<bits/stdc++.h>
using namespace std;

//Tower Of Honai Problem this the pure Recursive problem 
//da-durjoy@outlook.com
void TowerOfHonai(int n,char first,char second,char third)
{
    if(n==1)
    {
        cout<<"Disk "<<n<<" moved "<<"from "<<first<<" to "<<second<<'\n';
        return;
    }
    TowerOfHonai(n-1,first,third,second);
    cout<<"Disk "<<n<<" moved "<<"from "<<first<<" to "<<second<<'\n';
    TowerOfHonai(n-1,third,second,first);
}

int main()
{
    TowerOfHonai(3,'A','B','C');
    return 0;
}
