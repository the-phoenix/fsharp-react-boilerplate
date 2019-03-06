#r "../node_modules/fable-core/Fable.Core.dll"
#r "../node_modules/fable-react/Fable.React.dll"

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

module R = Fable.Helpers.React
open R.Props

type [<Pojo>] AppProps =
    { message: string }

type [<Pojo>] AppState = { state: string }

type App(props) =
    inherit React.Component<AppProps, AppState>(props)
    member this.render () =
        // The React helper defines a simple DSL to build HTML elements.
        // For more info about transforming F# unions to JS option objects:
        // https://fable-compiler.github.io/docs/interacting.html#KeyValueList-attribute
        R.h1 [] [ R.str this.props.message ]

let render() =
    ReactDom.render(
        R.com<App,_,_> { message = "Hello World" } [],
        Browser.document.getElementById("sample")
    )
render()