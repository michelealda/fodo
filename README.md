# Yet another to-do list living in the terminal, but this time in F#

Inspired by [this to-do list written in Rust](https://github.com/sioodmy/todo) I decided to port some of the code in F# to spruce up my knowledge and have something useful running on my Windows Terminal.

For now is a simpler `fsx` script, might become a fully fledge command tool later on.

## How to run it

- Clone the repository 
- Create a `todo.txt` file in the same folder
- Run `dotnet fsi ./fodo.fsx` to list the content
- Add items to the list by `dotnet fsi ./fodo.fsx add item1 item2 item3`
- Set done items by `dotnet fsi ./fodo.fsx done 1 2`
- Remove done items by `dotnet fsi ./fodo.fsx rm 1 2`

## Next steps

- Run it from everywhere
- Make the output nicer
- Lear Rust :wink:
