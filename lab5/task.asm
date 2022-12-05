.386
.model flat, stdcall
option casemap: none

include C:\masm32\include\windows.inc
include C:\masm32\include\kernel32.inc
includelib C:\masm32\lib\kernel32.lib

.data
bvar dw 3
cvar dw 2
dvar dw 5
yvar dw 4

.data?
avar dw ?

.code ; a = (b^2)*(y+d)+(d-1)/c
start:
    mov cx, bvar ; cx = b
    mov ax, cx
    imul cx ; cx = b*b
    mov bx, yvar ; bx = y
    add bx, dvar ; bx = y + d
    imul ax, bx ; ax = (b^2)*(y+d)
    mov cx, ax
    mov ax, dvar
    dec ax ; dx = d - 1
    idiv cvar ; ax = (d - 1)/c
    add cx, ax

    mov avar, cx
    
    invoke ExitProcess, NULL
end start