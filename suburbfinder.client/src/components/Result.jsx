const Result = ({ suburb }) => {
    const { id, name, longitude, latitude } = suburb;

    return (
        <div className="block max-w-md py-6 px-4 mt-12 bg-white border border-gray-200 rounded-lg shadow dark:bg-green-950 dark:border-green-900">
            <p className="mb-4 text-md font-normal text-gray-700 dark:text-green-100">The nearest suburb is</p>
            <h5 className="mb-4 text-5xl font-bold tracking-tight text-gray-900 dark:text-white">{name}</h5>
            <p className="font-normal text-gray-700 dark:text-green-100"><span className="font-bold">Longitude:</span> {longitude} - <span className="font-bold">Latitude:</span> {latitude}</p>
        </div>
    )
}

export default Result