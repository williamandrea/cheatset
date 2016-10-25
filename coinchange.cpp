#include<bits/stdc++.h>
using namespace std;

	int m,n,a[1000],memo[1000];
int solve(int x){
	if (x==0){
		return 0;
	}else if (memo[x]!=0){
		return memo[x];
	}else{
		int best=1000000000;
		for (int k=0; k<m; k++){
			if (a[k]<=x){
				best=min(best,solve(x-a[k])+1);
			}
		}
		memo[x]=best;
		return best;
	}
	
	
}
int main(){
	cin>>m>>n;
	for (int i=0; i<m; i++){
		cin>>a[i];
	}
	cout<<solve(n)<<endl;
	return 0;
}
