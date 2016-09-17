var
        t,tc,p,a,b,i:longint;
        x:array[0..100000] of longint;
begin
        readln(t);
        for tc:=1 to t do begin
                p:=0;
                readln(a,b);
                if (b=0) then writeln(0)
                else begin
                        while (b<>0) do begin
                                if (a=1) then begin
                                        inc(p);
                                        x[p]:=b;
                                        b:=0;
                                end else if (a>1) and (a mod 2=0) then begin
                                        a:=a div 2;
                                        b:=b*2;
                                end else if (a>1) and (a mod 2=1) then begin
                                        inc(p);
                                        x[p]:=b;
                                        a:=(a-1) div 2;
                                        b:=b*2;
                                end;
                        end;

                        for i:=1 to p do begin
                                if (i=p) then writeln(x[i])
                                else write(x[i],' + ');
                        end;
                end;
        end;
end.