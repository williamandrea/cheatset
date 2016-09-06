function search(var a:array of longint; v,l,h:longint):longint;
var
        m:longint;
begin
        if (h<l) then search:=l
        else begin
             m:=(l+h) div 2;
             if (a[m]>v) then search:=search(a,v,l,m-1)
             else search:=search(a,v,m+1,h);
        end;
end;

var
        n,s,i:longint;
        x:array[0..1000] of longint;
begin
        readln(n,s);
        for i:=0 to n-1 do begin
                read(x[i]);
        end;
        writeln(search(x,s,0,n-1));
end.