const coordinatesReducer = (state = {}, action) => {
    switch(action.type) {
      case "coordinates/setCoordinates":
        return action.payload
      default: 
        return state
    }
}

export const setCoordinates = (coordinates) => {
  return ({
    type: "coordinates/setCoordinates",
    payload: coordinates
  })
}

export default coordinatesReducer