def atbash(str):
    out= "";
    for x in str:
        if((x >= 'a') and (x <= 'z')):
            x= chr(ord('z')+ord('a') - ord(x));
        if((x >= 'A') and (x <= 'Z')):
            x= chr(ord('Z')+ord('A') - ord(x));
        out+= x;
    return out;
print(atbash("apple"));
print(atbash("Hello world!"));
print(atbash("Christmas is the 25th of December"));