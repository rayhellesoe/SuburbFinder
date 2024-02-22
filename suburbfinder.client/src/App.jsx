import './App.css';
import { useSelector } from 'react-redux'
import CoordinatesForm from './components/CoordinatesForm';
import Result from './components/Result'

const App = () => {
    const nearestSuburb = useSelector(state => state.suburbs)
    const isNearestSuburbEmpty = Object.keys(nearestSuburb).length === 0
    const resultElement = isNearestSuburbEmpty ? <></> : <Result suburb={nearestSuburb} />

    return (
        <main className="flex justify-center w-full">
            <div className="max-w-md">
                <h1 className="text-5xl font-bold mb-4">Suburb Finder</h1>
                <p className="mb-6">Input a set of coordinates to find the nearest suburb.</p>
                <CoordinatesForm />
                { resultElement }
            </div>
        </main>
    )
}

export default App;