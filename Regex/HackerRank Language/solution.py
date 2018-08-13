languages = ('C', 'CPP', 'JAVA', 'PYTHON', 'PERL', 'PHP', 'RUBY', 'CSHARP', 'HASKELL', 'CLOJURE', 'BASH', 'SCALA', 'ERLANG', 'CLISP', 'LUA', 'BRAINFUCK', 'JAVASCRIPT', 'GO', 'D', 'OCAML', 'R', 'PASCAL', 'SBCL', 'DART', 'GROOVY', 'OBJECTIVEC')

lines = int(input())

while lines > 0:
    line = str(input())
    words=line.split(' ')
    if words[1] in languages:
        print('VALID')
    else:
        print('INVALID')
    lines -= 1