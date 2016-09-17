var
        t,tc,n,i,j,a,tmp,p:longint;
        baris,kolom:array[1..1000] of longint;
begin
        readln(t);
        for tc:=1 to t do begin
                readln(n);
                for i:=1 to n do begin
                        baris[i]:=0;
                        kolom[i]:=0;
                end;
                for i:=1 to n do begin
                        baris[i]:=0;
                        for j:=1 to n do begin
                                read(a);
                                if (a=1) then begin
                                        inc(baris[i]);
                                        inc(kolom[j]);
                                end;
                        end;
                end;
                {for i:=1 to n do begin
                        for j:=1 to n do begin
                                write(baris[i],kolom[j],' ');
                        end;
                        writeln;
                end;}
                p:=0;
                for i:=1 to n do begin
                        if kolom[i] mod 2=1 then begin
                                inc(p);
                                tmp:=i;
                        end;
                end;
                //writeln(p);
                if p=0 then begin
                        writeln(n,' = Telah dicek dan OK!');
                end else if p=1 then begin
                        for i:=1 to n do begin
                                if baris[i] mod 2=1 then begin
                                        writeln(n,' = Ganti bit (',i,',',tmp,')');
                                end;
                        end;
                end else begin
                        writeln(n,' = File Rusak');
                end;

        end;
end.