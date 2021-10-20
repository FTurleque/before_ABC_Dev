class Carousel {

    /**
     * This callback type is called 'requestCallback' and is displayed as a global symbol.
     * 
     * @callback    moveCallback
     * @param {number} index 
     */


    /**
     * @param {HTMLElement} element 
     * @param {Object} options 
     * @param {Object} [options.slidesToScroll=1]  Nombre d'élément a faire défiler
     * @param {Object} [options.slidesVisible=1]  Nombre d'élément visible
     * @param {boolean} [options.loop=false]  Doit-on boucler en fin de carousel
     */
    constructor(element, options = {}) {
        this.element = element
        this.options = Object.assign({}, {
            slidesToScroll: 1,
            slidesVisible: 1,
            loop: false
        }, options)
        let children = [].slice.call(element.children)
        this.currentItem = 0
        let ratio = children.length / this.options.slidesVisible
        this.root = this.createDivWithClass('carousel')
        this.container = this.createDivWithClass('carousel__container')
        this.container.style.width = (ratio * 100) + "%"
        this.root.appendChild(this.container)
        this.element.appendChild(this.root)
        this.moveCallbacks = []
        this.items = children.map((child) => {
            let item = this.createDivWithClass('carousel__item')
            item.style.width = ((100 / this.options.slidesVisible) / ratio) + "%"
            item.appendChild(child)
            this.container.appendChild(item)
            return item
        })
        this.createNavigation()
        this.moveCallbacks.forEach(cb => cb(0))
    }

    setStyle() {

    }

    createNavigation() {
        let nextButton = this.createDivWithClass('carousel__next')
        let prevButton = this.createDivWithClass('carousel__prev')
        this.root.appendChild(nextButton)
        this.root.appendChild(prevButton)
        nextButton.addEventListener('click', this.next.bind(this))
        prevButton.addEventListener('click', this.prev.bind(this))
        if (this.options.loop === true) {
            return
        }
        this.onMove(index => {
            if (index === 0) {
                prevButton.classList.add('carousel__prev--hidden')
            } else {
                prevButton.classList.remove('carousel__prev--hidden')
            }
            if (this.items[this.currentItem + this.options.slidesVisible] === undefined) {
                nextButton.classList.add('carousel__next--hidden')
            } else {
                nextButton.classList.remove('carousel__next--hidden')
            }
        })
    }

    next() {
        this.gotoItem(this.currentItem + this.options.slidesToScroll)
    }

    prev() {
        this.gotoItem(this.currentItem - this.options.slidesToScroll)
    }

    /**
     * Déplace le carousel vers l'élément ciblé
     * @param {number} index
     */
    gotoItem(index) {
        if (index < 0) {
            index = this.items.length - this.options.slidesVisible
        } else if (index >= this.items.length || (this.items[this.currentItem + this.options.slidesVisible] === undefined && index > this.currentItem)) {
            index = 0
        }
        let translateX = index * -100 / this.items.length
        this.container.style.transform = 'translate3d(' + translateX + '%, 0, 0)'
        this.currentItem = index
        this.moveCallbacks.forEach(cb => cb(index))
    }

    /**
     * 
     * @param {moveCallback} cb 
     */
    onMove(cb) {
        this.moveCallbacks.push(cb)
    }

    /**
    * 
    * @param {sting} className 
    * @returns {HTMLElement}
    */
    createDivWithClass(className) {
        let div = document.createElement('div')
        div.setAttribute('class', className)
        return div
    }

}


document.addEventListener('DOMContentLoaded', function () {
    new Carousel(document.querySelector('#action'), {
        slidesVisible: 8,
        slidesToScroll: 3,
    })

    // new Carousel(document.querySelector('#annimation'), {
    //     slidesVisible: 8,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#aventure'), {
    //     slidesVisible: 8,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#comedie'), {
    //     slidesVisible: 8,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#drame'), {
    //     slidesVisible: 8,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#famillial'), {
    //     slidesVisible: 8,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#fantastique'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#guerre'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#histoire'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#horreur'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#musique'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#science-fiction'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })
    
    // new Carousel(document.querySelector('#telefilms'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#thriller'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })

    // new Carousel(document.querySelector('#western'), {
    //     slidesVisible: 6,
    //     slidesToScroll: 3,
    // })


})